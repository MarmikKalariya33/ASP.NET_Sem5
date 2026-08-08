using Ecommerse.DTOs;
using Ecommerse.Model;
using Ecommerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usercontroller : ControllerBase
    {
        private readonly Iuserservices _userservices;

        public usercontroller(Iuserservices userservices)
        {
            _userservices = userservices;
        }

        [HttpPost]
        [Route("Getuserdetail")]
        public async Task<IActionResult> Getuserdetail(loginDTO obj)
        {
            var user = await _userservices.Getuserdetail(obj);
            return Ok(user);
        }
    }
}