namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataDbContext _context;

        public ProductService(DataDbContext context)
        {
            _context = context;
        }

        public async Task<ServicesResponse<Product>> GetProductByIdAsync(int id)
        {
            var response = new ServicesResponse<Product>();
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product doesn't exist.";
            }
            else
            {
                response.Data = product;
            }
            return response;
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
