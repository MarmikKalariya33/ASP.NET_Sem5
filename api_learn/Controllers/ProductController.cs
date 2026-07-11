using api_learn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace api_learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllProducts")] // security
        public List<ProductMaster> GetAllProducts()
        {
            var Products = _context.ProductMasters.ToList();
            //Select * from productMaster
            return Products;
        }

        [HttpPost]
        [Route("createNewProduct")]
       
        public ProductMaster createNewProduct(ProductMaster obj)
        {
            _context.ProductMasters.Add(obj);
            //Insert into ProductMaster
            _context.SaveChanges();
            return obj;
        }
        [HttpPut]
        [Route("UpdateProduct")]

        public ProductMaster UpdateProduct(ProductMaster obj)
        {
            var Products = _context.ProductMasters.SingleOrDefault(x => x.Pro_Id == obj.Pro_Id);
            Products.Pro_Name = obj.Pro_Name;
            Products.Pro_Category = obj.Pro_Category;
            Products.Pro_Qty = obj.Pro_Qty;
            Products.Pro_Price = obj.Pro_Price;
            _context.SaveChanges();
            return obj;
        }
    }
}
