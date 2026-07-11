using Microsoft.EntityFrameworkCore;
namespace api_learn.Models
{
    public class AppDbContext : DbContext
    {
        // appdbcontect is constructor 
        // after line constructor parametre
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)//pass option as a parameter to the base class constructor
                                                                                   //base = paarent class, derived class = child class, base class
        {

        }
        // register tabel here ... 
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<CampanyMaster> CampanyMasters { get; set; }
    }
}
