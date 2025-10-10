using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    [QueryProperty(nameof(Category), nameof(Category))]
    public partial class ProductCategoriesViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private string searchText = "";
        public ObservableCollection<ProductCategory> ProductCategories { get; set; } = [];
        public ObservableCollection<Product> AvailableProducts { get; set; } = [];

        [ObservableProperty]
        Category category = new(0, "None");
        public ProductCategoriesViewModel(IProductCategoryService productCategoryService, IProductService productService) 
        { 
            _productCategoryService = productCategoryService;
            _productService = productService;
            //AvailableProducts = GetAvailableProducts();
            Load(category.Id);
        }

        private void Load(int categoryId)
        {
            ProductCategories.Clear();
            foreach (var item in _productCategoryService.GetAllOnCategoryId(categoryId))
            {
                ProductCategories.Add(item);
            }
        }
        partial void OnCategoryChanged(Category oldValue, Category newValue) 
        { 
            Category = newValue;
            Title = newValue.Name;
            Load(newValue.Id);
        }
        private void GetAvailableProducts()
        {
            throw new NotImplementedException();
        }
        [RelayCommand]
        public void AddProduct(Product product) { throw new NotImplementedException(); }
        [RelayCommand]
        public void PerformSearch(string searchText) { throw new NotImplementedException(); }
    }

}
