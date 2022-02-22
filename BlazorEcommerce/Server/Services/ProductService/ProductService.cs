namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataDbContext _context;

        public ProductService(DataDbContext context)
        {
            _context = context;
        }

        public async Task<ServicesResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServicesResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }
    }
}
