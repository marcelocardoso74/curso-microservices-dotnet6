using GeekShopping.Web.Models;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services.IServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/Product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindAllProductByID(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }


        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJason(BasePath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProductModel>();
            }
            else
            {
                throw new Exception("Erro na criação do produto");
            }
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _client.PutAsJason(BasePath, model);
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProductModel>();
            }
            else
            {
                throw new Exception("Erro na atualização do produto");
            }
        }

        public async Task<bool> DeleteProductByID(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<bool>();
            }
            else
            {
                throw new Exception("Erro na deleção do produto");
            }
        }

    }
}
