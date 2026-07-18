using api_learn.Models;

namespace api_learn.Services
{
    public interface IProductService
    {
       Task <List<ProductMaster>> GetAllProducts();
    }
}