using Grocery.Core.Interfaces.Services;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryService(IProductCategoryService productCategoryService) 
        { 
            _productCategoryService = productCategoryService;
        }

        public List<Models.ProductCategory> GetAll()
        {
            return _productCategoryService.GetAll();
            //throw new NotImplementedException();
        }

        public Models.ProductCategory Add(Models.ProductCategory item)
        {
            return _productCategoryService.Add(item);
        }

        public List<Models.ProductCategory> GetAllOnCategoryId(int id)
        {
            return _productCategoryService.GetAllOnCategoryId(id);
        }
    }
}
