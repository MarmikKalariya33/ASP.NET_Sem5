using api_learn.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ProductMaster> CreateNewProduct(ProductMaster obj)
        {
            await _context.ProductMasters.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<ProductMaster> UpdateProduct(ProductMaster obj)
        {
            var product = await _context.ProductMasters
                .SingleOrDefaultAsync(x => x.Pro_Id == obj.Pro_Id);

            if (product == null)
            {
                return null;
            }

            product.Pro_Name = obj.Pro_Name;
            product.Pro_Category = obj.Pro_Category;
            product.Pro_Qty = obj.Pro_Qty;
            product.Pro_Price = obj.Pro_Price;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<ProductMaster> DeleteProduct(int Pro_Id)
        {
            var product = await _context.ProductMasters
                .SingleOrDefaultAsync(x => x.Pro_Id == Pro_Id);

            if (product != null)
            {
                _context.ProductMasters.Remove(product);
                await _context.SaveChangesAsync();
            }

            return product;
        }


    }
}