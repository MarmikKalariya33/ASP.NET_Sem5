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

        // Change Password services 
        public async Task<ResponseDTOs> ChangePassword(ChangePasswordDTO obj)
        {
            ResponseDTOs response = new ResponseDTOs();

            // 1. Check User ID and Current Password
            var user = await _context.users
                .FirstOrDefaultAsync(x =>
                    x.userId == obj.userId &&
                    x.userPass == obj.CurrentPassword);

            // 2. User not found / Current password incorrect
            if (user == null)
            {
                response.Success = false;
                response.Message = "Current password is incorrect.";
                return response;
            }

            // 3. Check New Password and Confirm Password
            if (obj.NewPassword != obj.ConfirmPassword)
            {
                response.Success = false;
                response.Message = "New password and confirm password must be the same.";
                return response;
            }

            // 4. Update New Password
            user.userPass = obj.NewPassword;

            // 5. Save changes into database
            await _context.SaveChangesAsync();

            // 6. Success response
            response.Success = true;
            response.Message = "Password changed successfully.";

            return response;
        }

    }
   
}