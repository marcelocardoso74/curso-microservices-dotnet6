using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {

        Task<IEnumerable<ProductVO>> Findall();
        Task<ProductVO> FindByID(long id);
        Task<ProductVO> Create(ProductVO vo);
        Task<ProductVO> UpdateByID(ProductVO vo);
        Task<bool> DeleteByID(long id);

    }
}
