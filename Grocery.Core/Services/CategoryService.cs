using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

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
        public Category? Update(Category item)
        {
            return _categoryService.Update(item);
        }
    }
}
