using api_learn.Models;
using api_learn.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductServices _services;
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context, ProductServices services)
        {
            _context = context;
            _services = services;
        }

        [HttpGet]
        [Route("GetAllProducts")] // security
        public async Task<IActionResult> GetAllProducts() // async return task 
        {
            var Products = await _services.GetAllProducts();
            //Select * from productMaster
            return Ok(Products);
        }

        [HttpPost]
        [Route("createNewProduct")]

        public async Task<IActionResult> createNewProduct(ProductMaster obj)
        {
            await _context.ProductMasters.AddAsync(obj);
            //Insert into ProductMaster
            _context.SaveChanges();
            return Ok(obj);
        }

        [HttpPut]
        [Route("UpdateProduct")]

        public async Task<ProductMaster> UpdateProduct(ProductMaster obj)
        {
            var product = await _context.ProductMasters.SingleOrDefaultAsync(x => x.Pro_Id == obj.Pro_Id);
            product.Pro_Name = obj.Pro_Name;
            product.Pro_Category = obj.Pro_Category;
            product.Pro_Qty = obj.Pro_Qty;
            product.Pro_Price = obj.Pro_Price;
            _context.SaveChanges();
            return product;
        }

        [HttpDelete]
        [Route("DeleteProduct")]

        public async Task<IActionResult> Deleteproduct(int Pro_Id)
        {
            var product = await _context.ProductMasters.SingleOrDefaultAsync(x => x.Pro_Id == Pro_Id);
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
                return Ok(product); // ok sucess 200 
                                    // notfound 404
            }
            else
            {
                return NotFound();
            }
        }
    }
}
