using GLC_DesignPatterns.DIP.API.GoodExample.Models;
using GLC_DesignPatterns.DIP.API.GoodExample.Repositories;

namespace GLC_DesignPatterns.DIP.API.GoodExample.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        public List<ProductDto> GetAllProducts()
        {
            var productList = productRepository.GetAllProducts();
            return productList.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
