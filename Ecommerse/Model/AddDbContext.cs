using Microsoft.EntityFrameworkCore;

namespace Ecommerse.Model
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options)
            : base(options)
        {
        }

        public DbSet<user> users { get; set; }
    }
}