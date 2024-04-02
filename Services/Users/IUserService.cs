using HK2TProject_HotelManage_Server.Models.Authenticate;
using Supabase.Gotrue;

namespace HK2TProject_HotelManage_Server.Services.Users
{
    public interface IUserService
    {
        Task<Models.Users> Validate(LoginUser loginUser);
        Task<Models.Users> GetUserById(int userId);
    }
}
