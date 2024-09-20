using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }

        public async Task<IEnumerable<ProductVO>> Findall()
        {

            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindByID(long id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> UpdateByID(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByID(long id)
        {
            throw new NotImplementedException();
        }



    }
}
