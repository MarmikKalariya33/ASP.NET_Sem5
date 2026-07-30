using Microsoft.EntityFrameworkCore;
using Ecommerse.Model;
using Ecommerse.DTOs;

namespace Ecommerse.Services
{
    public class userservices
    {
        private readonly AddDbContext _context;

        public userservices(AddDbContext context)
        {
            _context = context;
        }

        public async Task<loginDTO> GetUserdetails(loginDTO logindto)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.userName == logindto.userName
            && x.userPass == logindto.userPass);
            await _context.SaveChangesAsync();

            return logindto;
        }
    }
}