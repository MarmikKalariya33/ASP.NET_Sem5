using Ecommerse.DTOs;
using Ecommerse.Model;

namespace Ecommerse.Services
{
    public interface Iuserservices
    {
        Task<loginDTO> Getuserdetail(loginDTO obj);

        Task<ResponseDTOs> Register(RegisterDTO obj);
        Task<ResponseDTOs> ChangePassword(ChangePasswordDTO obj);

    }
}