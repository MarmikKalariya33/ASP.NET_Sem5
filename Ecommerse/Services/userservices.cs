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

        public async Task<loginDTO> Getuserdetail(loginDTO obj)
        {
            var user = await _context.users.FirstOrDefaultAsync(x =>
                x.userName == obj.userName &&
                x.userPass == obj.userPass);

            return obj;
        }
    }
}