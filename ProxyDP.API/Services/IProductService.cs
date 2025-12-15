namespace ProxyDP.API.Services
{
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(CreateProductRequest productDto);
    }
}
