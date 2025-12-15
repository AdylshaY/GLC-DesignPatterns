using ProxyDP.API.Repositories;

namespace ProxyDP.API.Services
{
    public class ProductService(Repositories.IProductRepository productRepository) : IProductService
    {
        public async Task<ProductDto> CreateAsync(CreateProductRequest productDto)
        {
            //var userName = httpContextAccessor.HttpContext!.User.Identity!.Name!;

            //var user = await userManager.FindByNameAsync(userName);

            //if (user is not null && user.MembershipType == MembershipType.Free) throw new UnauthorizedAccessException("Free members cannot create products.");

            var product = new Product
            {
                Id = productDto.Id,
                Name = productDto.Name
            };

            var createdProduct = await productRepository.CreateAsync(product);
            return new ProductDto(createdProduct.Id, createdProduct.Name);
        }
    }
}
