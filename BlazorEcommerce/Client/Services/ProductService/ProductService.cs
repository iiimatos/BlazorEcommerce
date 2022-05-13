﻿

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

        public async Task<ServicesResponse<Product>> GetProductById(int id)
        {
            return await _http.GetFromJsonAsync<ServicesResponse<Product>>($"api/product/{id}");
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServicesResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
                Products = result.Data;
        }
    }
}
