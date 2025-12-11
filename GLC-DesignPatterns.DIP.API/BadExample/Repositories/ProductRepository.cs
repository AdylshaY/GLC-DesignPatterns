using GLC_DesignPatterns.DIP.API.BadExample.Models;

namespace GLC_DesignPatterns.DIP.API.BadExample.Repositories
{
    internal class ProductRepository
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
