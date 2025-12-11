using GLC_DesignPatterns.DIP.API.GoodExample.Models;
using GLC_DesignPatterns.DIP.API.GoodExample.Repositories;

namespace GLC_DesignPatterns.DIP.API.GoodExample.Services
{
    public class ProductService : IProductService
    {
        public List<ProductDto> GetAllProducts()
        {
            var productRepository = new ProductRepository();
            var productList = productRepository.GetAllProducts();
            return productList.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
