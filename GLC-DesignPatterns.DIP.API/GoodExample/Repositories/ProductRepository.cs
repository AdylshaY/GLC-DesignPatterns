using GLC_DesignPatterns.DIP.API.GoodExample.Models;

namespace GLC_DesignPatterns.DIP.API.GoodExample.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return
            [
                new()
                {
                    Id = 1,
                    Name = "Product A"
                },
                new()
                {
                    Id = 2,
                    Name = "Product B"
                },
                new()
                {
                    Id = 3,
                    Name = "Product C"
                }
            ];
        }
    }
}
