using Microsoft.EntityFrameworkCore;
using Ecommerse.Model;
using Ecommerse.DTOs;

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
        public async Task<regis?> Register(RegisterDTO obj)
        {
            var user = await _context.users
                .FirstOrDefaultAsync(x => x.userName == obj.userName);

            if (user != null)
            {
                return null;
            }

            user newUser = new user
            {
                userName = obj.userName,
                userPass = obj.userPass
            };

            await _context.users.AddAsync(newUser);

            await _context.SaveChangesAsync();

            return new regis
            {
                userName = obj.userName,
                userPass = obj.userPass
            };
        }
    }
}