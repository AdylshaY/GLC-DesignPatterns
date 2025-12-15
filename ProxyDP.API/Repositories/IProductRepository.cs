namespace ProxyDP.API.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product);
    }

    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task<Product> CreateAsync(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }
    }
}
