using Ecommerse.DTOs;
using Ecommerse.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerse.Services
{
    public interface Iuserservices
    {
        public Task<loginDTO> Getuserdetail(loginDTO obj);

    }
}
