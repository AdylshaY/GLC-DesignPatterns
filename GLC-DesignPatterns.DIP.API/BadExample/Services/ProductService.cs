using GLC_DesignPatterns.DIP.API.BadExample.Models;
using GLC_DesignPatterns.DIP.API.BadExample.Repositories;

namespace GLC_DesignPatterns.DIP.API.BadExample.Services
{
    internal class ProductService
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
