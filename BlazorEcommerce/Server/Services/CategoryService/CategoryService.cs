namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataDbContext _context;

        public CategoryService(DataDbContext context)
        {
            _context = context;
        }
        public async Task<ServicesResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServicesResponse<List<Category>>
            {
                Data = categories,
            };
        }
    }
}
