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
        private readonly userservices _userservices;

        public usercontroller(userservices userservices)
        {
            _userservices = userservices;
        }

        [HttpPost]
        [Route("Getuserdetail")]
        public async Task<IActionResult> Getuserdetail(loginDTO obj)
        {
            var user = await _userservices.GetUserdetails(obj);
            return Ok(user);
        }
    }
}