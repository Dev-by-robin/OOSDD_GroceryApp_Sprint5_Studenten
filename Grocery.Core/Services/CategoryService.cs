using Grocery.Core.Interfaces.Services;

namespace Grocery.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Models.Category> GetAll()
        {
            return _categoryService.GetAll();
            //throw new NotImplementedException();
        }
    }
}
