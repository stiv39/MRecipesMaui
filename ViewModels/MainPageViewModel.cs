using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MRecipes.Models;
using MRecipes.Storage;

namespace MRecipes.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly DataContext _dataContext;

    public MainPageViewModel(DataContext dataContext)
    {
        _dataContext = dataContext;

        Categories = _dataContext.Categories.ToList();
    }

    [ObservableProperty]
    private List<Category> _categories = new();

    [RelayCommand]
    private void SelectCategory(Guid id)
    {
        var navigationParameter = new ShellNavigationQueryParameters
        {
            { "id", id }
        };
        Shell.Current.GoToAsync("category", navigationParameter);
    }
}
