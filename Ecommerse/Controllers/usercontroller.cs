using Ecommerse.DTOs;
using Ecommerse.Model;
using Ecommerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly Iuserservices _userservices;

        public userController(Iuserservices userservices)
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

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterDTO obj)
        {
            var user = await _userservices.Register(obj);

            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Username already exists"
                });
            }

            return Ok(new
            {
                message = "Registration successful",
                userName = user.userName,
                userPass = user.userPass
            });
        }
    }
}