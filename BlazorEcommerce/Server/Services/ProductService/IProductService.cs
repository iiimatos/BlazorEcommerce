namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServicesResponse<Product>> GetProductByIdAsync(int id);
        Task<ServicesResponse<List<Product>>> GetProductsAsync();

    }
}
