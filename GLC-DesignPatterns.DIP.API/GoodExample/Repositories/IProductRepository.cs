using GLC_DesignPatterns.DIP.API.GoodExample.Models;

namespace GLC_DesignPatterns.DIP.API.GoodExample.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
    }
}
