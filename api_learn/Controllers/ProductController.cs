using api_learn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [Route("GetAllProducts")]
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
            _context.SaveChanges();
            return obj;
        }
    }
}
