using api_learn.Models;
using Microsoft.EntityFrameworkCore;

namespace api_learn.Services
{
    public class ProductServices
    {
        private readonly AppDbContext _context;
        public ProductServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductMaster>> GetAllProducts() // async return task 
        {
            return await _context.ProductMasters.ToListAsync();
            //Select * from productMaster
            
        }
    }
}
