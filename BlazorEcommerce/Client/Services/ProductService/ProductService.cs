

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServicesResponse<Product>> GetProductById(int id)
        {
            return await _http.GetFromJsonAsync<ServicesResponse<Product>>($"api/product/{id}");
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                    await _http.GetFromJsonAsync<ServicesResponse<List<Product>>>("api/product"):
                    await _http.GetFromJsonAsync<ServicesResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;
            ProductsChanged.Invoke();
        }
    }
}
