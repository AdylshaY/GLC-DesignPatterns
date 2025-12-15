using Microsoft.AspNetCore.Identity;
using ProxyDP.API.Repositories;

namespace ProxyDP.API.Services.Proxies
{
    public class ProductServiceAccessProxy(IProductService productService, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager) : IProductService
    {
        public async Task<ProductDto> CreateAsync(CreateProductRequest productDto)
        {
            if (httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated == true)
            {
                var userName = httpContextAccessor.HttpContext.User.Identity.Name!;
                var user = await userManager.FindByNameAsync(userName);

                if (user is not null && user.MembershipType == MembershipType.Free)
                    throw new UnauthorizedAccessException("Free members cannot create products.");

                return await productService.CreateAsync(productDto);
            }

            throw new UnauthorizedAccessException("User is not authenticated.");
        }
    }
}
