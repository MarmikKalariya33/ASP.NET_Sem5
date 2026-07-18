using api_learn.Models;
using Microsoft.EntityFrameworkCore;

namespace api_learn.Services
{
    public class ProductServices : IProductService
    {
        private readonly AppDbContext _context;

        public ProductServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductMaster>> GetAllProducts()
        {
            return await _context.ProductMasters.ToListAsync();
        }

        
    }
}