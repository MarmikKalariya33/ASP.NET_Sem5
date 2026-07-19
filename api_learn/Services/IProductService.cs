using api_learn.Models;

namespace api_learn.Services
{
    public interface IProductService
    {
       Task <List<ProductMaster>> GetAllProducts();

       Task<ProductMaster> CreateNewProduct(ProductMaster obj);

       Task<ProductMaster> UpdateProduct(ProductMaster obj);

       Task<ProductMaster> DeleteProduct(int Pro_Id);
    }
}