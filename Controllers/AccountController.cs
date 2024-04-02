using HK2TProject_HotelManage_Server.Models.Authenticate;
using HK2TProject_HotelManage_Server.Services.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration; //Thêm thư viện này


namespace HK2TProject_HotelManage_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("loginDEMO")]
        public async Task<IActionResult> Login([FromBody] LoginUser loginUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userService.Validate(loginUser);
                    if (user != null)
                    {
                        // Đăng nhập thành công, trả về thông tin người dùng hoặc token JWT
                        return Ok(new { message = "Login successful", user = user });
                    }
                    else
                    {
                        // Sai thông tin đăng nhập
                        return BadRequest(new { message = "Invalid email or password" });
                    }
                }
                else
                {
                    // Dữ liệu đầu vào không hợp lệ
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                return StatusCode(500, new { error = "Internal server error" });
            }
        }


        [HttpPost("loginMAIN")]
        public async Task<IActionResult> LoginMain([FromBody] LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userService.Validate(user);
                if (existingUser != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, existingUser.id.ToString()),
                        new Claim(ClaimTypes.Role, existingUser.position.ToString()),
                    };

                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSetting["JWT:Secret"]));

                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: ConfigurationManager.AppSetting["JWT:ValidIssuer"],
                        audience: ConfigurationManager.AppSetting["JWT:ValidAudience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(6),
                        signingCredentials: signinCredentials
                    );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    return Ok(new JWTTokenResponse { Token = tokenString });
                }
            }

            return Unauthorized();
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            // Perform logout actions if needed (e.g., invalidate tokens, clear session)
            return Ok(new { message = "Logout successful" });
        }

        //method POST isLogin get the token from form and validate it

        [HttpPost("isLogin")]
        public async Task<IActionResult> IsLogin([FromBody] JWTTokenResponse token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(ConfigurationManager.AppSetting["JWT:Secret"]);
            token.Token = token.Token.Replace("Bearer ", "");

            try
            {
                tokenHandler.ValidateToken(token.Token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = ConfigurationManager.AppSetting["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = ConfigurationManager.AppSetting["JWT:ValidAudience"],
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                // Token is valid, you can perform additional checks if needed
                return Ok(new { message = "Token is valid" });
            }
            catch (Exception ex)
            {
                // Token validation failed, handle the exception or log it
                // For security reasons, you might want to avoid exposing details of the error to clients
                return Unauthorized(new { error = "Token validation failed" });
            }
        }

        [Authorize]
        [HttpGet("accountInfo")]
        public async Task<IActionResult> GetAccountInfo()
        {
            try
            {
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
                {
                    var user = await _userService.GetUserById(userId);

                    if (user != null)
                    {
                        var accountInfo = new
                        {
                            Name = user.surName,
                            Role = user.position,
                            Email = user.email
                        };

                        return Ok(accountInfo);
                    }
                }

                // User not found or missing claims
                return NotFound(new { error = "User information not found" });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine(ex);
                return StatusCode(500, new { error = "Internal server error" });
            }
        }
    }

    public class JWTTokenResponse
    {
        public string Token { get; set; }
    }

}

