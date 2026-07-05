using Microsoft.EntityFrameworkCore;
namespace api_learn.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
        {
            
        }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<CampanyMaster> CampanyMasters { get; set; }
    }
}
