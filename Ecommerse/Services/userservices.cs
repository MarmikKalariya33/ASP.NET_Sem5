using Azure;
using Ecommerse.DTOs;
using Ecommerse.Model;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ecommerse.Services
{
    public class userservices : Iuserservices
    {
        private readonly AddDbContext _context;

        public userservices(AddDbContext context)
        {
            _context = context;
        }

        // Login services
        public async Task<loginDTO> Getuserdetail(loginDTO obj)
        {
            var user = await _context.users.FirstOrDefaultAsync(x =>
                x.userName == obj.userName &&
                x.userPass == obj.userPass);

            return obj;
        }

        // Register services
        public async Task<ResponseDTOs> Register(RegisterDTO obj)
        {
            ResponseDTOs response = new ResponseDTOs();
            var user = await _context.users
                .FirstOrDefaultAsync(x => x.userName == obj.userName);

            if (user != null)
            {
                response.Success = false;
                response.Message = "Username allady exist ";
                return response;
            }
            if(obj.userPass != obj.conformPass)
            {
                response.Success = false;
                response.Message = "password and conform pass dont't match  ";
                return response;
            }


            user newUser = new user
            {
                userName = obj.userName,
                userPass = obj.userPass
            };

            await _context.users.AddAsync(newUser);

            await _context.SaveChangesAsync();
            response.Success = true;
            response.Message = " successfull registration";
            return response;
        }
    }
}