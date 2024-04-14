using HK2TProject_HotelManage_Server.Models.Authenticate;
using Supabase.Gotrue;

namespace HK2TProject_HotelManage_Server.Services.Users
{

    // Lớp UserService thực thi giao diện IUserService, cung cấp các phương thức để tương tác với người dùng trong cơ sở dữ liệu
    public class UserService : IUserService
    {
        // Biến để lưu trữ context của CSDL
        private readonly SupabaseService _supabaseService;

        // Constructor vơi dependency injection để đưa context CSDL vào
        public UserService(SupabaseService supabaseService)
        {
            _supabaseService = supabaseService;
        }
        public async Task<Models.Users> Validate(LoginUser user)
        {
            // Sử dụng SupabaseService để kiểm tra xem người dùng có tồn tại không
            var users = await _supabaseService.GetUsers();
            var existingUser = users.FirstOrDefault(u => u.email == user.Email && u.password == user.Password);
            return existingUser;
        }

        public async Task<Models.Users> GetUserById(int id)
        {
            // Sử dụng SupabaseService để lấy thông tin người dùng dựa vào id
            var users = await _supabaseService.GetUsers();
            var user = users.FirstOrDefault(u => u.id == id);
            return user;
        }
    }


    }
