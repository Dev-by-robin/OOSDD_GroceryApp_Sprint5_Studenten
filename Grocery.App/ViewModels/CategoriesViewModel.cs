using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using System.Collections.ObjectModel;
using Grocery.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.App.ViewModels
{
    public partial class CategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService;
        public ObservableCollection<Category> Categories { get; set; }
        // Naam per productcategorie
        [ObservableProperty]
        public string? categoryName;

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            Categories = new(_categoryService.GetAll());
        }
        [RelayCommand]
        public async Task SelectCategory(Category category)
        {
            Dictionary<string, object> paramater = new() { { nameof(Category), category } };
            categoryName = category.Name;
            await Shell.Current.GoToAsync($"{nameof(Views.ProductCategoryView)}", true, paramater);
        }
    }

}
