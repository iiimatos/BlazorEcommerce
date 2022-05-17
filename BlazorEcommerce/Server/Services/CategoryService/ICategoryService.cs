namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServicesResponse<List<Category>>> GetCategories();
    }
}
