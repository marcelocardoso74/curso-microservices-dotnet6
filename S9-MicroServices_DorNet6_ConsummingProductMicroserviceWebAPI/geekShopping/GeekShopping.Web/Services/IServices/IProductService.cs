using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {

        Task<IEnumerable<ProductModel>> FindAllProducts();

        Task<ProductModel> FindAllProductByID(long id);

        Task<ProductModel> CreateProduct(ProductModel model);

        Task<ProductModel> UpdateProduct(ProductModel model);

        Task<bool> DeleteProductByID(long id);
    }
}
