using api_learn.DTOs;
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
        private readonly IProductService _services;
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context, IProductService services)
        {
            _context = context;  // this is dependencies injections 
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
            var product = await _services.CreateNewProduct(obj);
            //Insert into ProductMaster
            return Ok(obj);
        }

        [HttpPut]
        [Route("UpdateProduct")]

        public async Task<IActionResult> UpdateProduct(ProductMaster obj)
        {
            var product = await _services.UpdateProduct(obj);
            if (product == null)
            {
                return NotFound("Product Not Found");
            }
            return Ok(product);
        }

        [HttpDelete]
        [Route("DeleteProduct")]

        public async Task<IActionResult> Deleteproduct(int Pro_Id)
        {
            var product = await _services.DeleteProduct(Pro_Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        [Route("Getrecord")]
        public async Task<IActionResult> Getrecord()
        {
            var list = await (
                from product in _context.ProductMasters
                join company in _context.CampanyMasters
                on product.Cmp_Id equals company.Cmp_Id
                select new ProductDTO
                {
                    ProName = product.Pro_Name,
                    ProCategory = product.Pro_Category,
                    ProPrice = product.Pro_Price,
                    CmpName = company.Cmp_Name
                }).ToListAsync();

            return Ok(list);
        }
    }
}
