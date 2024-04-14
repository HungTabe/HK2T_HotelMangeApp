using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HK2TProject_HotelManage_Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SupabaseService _supabaseService;

        public AuthController(SupabaseService supabaseService)
        {
            _supabaseService = supabaseService;
        }

        [HttpGet("GetUsersList")]
        public async Task<IActionResult> Get()
        {
            var users = await _supabaseService.GetUsers();
            return Ok(users);
        }





























        //private readonly IConfiguration _configuration;
        //private readonly ApplicationDbContext _context;

        //public AuthController(IConfiguration configuration, ApplicationDbContext context)
        //{
        //    _configuration = configuration;
        //    _context = context;
        //}

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] Users user)
        //{
        //    var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.email == user.email && u.password == user.password);

        //    if (existingUser == null)
        //    {
        //        return Unauthorized();
        //    }

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //            new Claim(ClaimTypes.Name, existingUser.id.ToString()),
        //            new Claim(ClaimTypes.Role, existingUser.position.ToString())
        //        }),
        //        Expires = DateTime.UtcNow.AddHours(1), // Token sẽ hết hạn sau 1 giờ
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    var tokenString = tokenHandler.WriteToken(token);

        //    // Trả về token cho người dùng
        //    return Ok(new { Token = tokenString });
        //}
    }
}
