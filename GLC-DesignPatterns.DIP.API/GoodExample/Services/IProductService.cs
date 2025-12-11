using GLC_DesignPatterns.DIP.API.GoodExample.Models;

namespace GLC_DesignPatterns.DIP.API.GoodExample.Services
{
    public interface IProductService
    {
        public List<ProductDto> GetAllProducts();
    }
}
