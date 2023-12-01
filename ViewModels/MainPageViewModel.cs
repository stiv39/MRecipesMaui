using CommunityToolkit.Mvvm.ComponentModel;
using MRecipes.Models;
using MRecipes.Storage;

namespace MRecipes.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly DataContext _dataContext;

    public MainPageViewModel(DataContext dataContext)
    {
        _dataContext = dataContext;
        Recipes = _dataContext.Recipes.ToList();
    }

    [ObservableProperty]
    private List<Recipe> _recipes = new List<Recipe>();
}
