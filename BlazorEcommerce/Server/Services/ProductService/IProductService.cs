namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServicesResponse<Product>> GetProductByIdAsync(int id);
        Task<ServicesResponse<List<Product>>> GetProductsAsync();
        Task<ServicesResponse<List<Product>>> GetProductByCategoryAsync(string categoryUrl);

    }
}
