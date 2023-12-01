using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using MRecipes.Models;
using MRecipes.Storage;

namespace MRecipes.ViewModels;

public partial class CategoryContentViewModel : ObservableObject, IQueryAttributable
{
    private readonly DataContext _dataContext;

    public Guid Id { get; private set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Id = Guid.Parse(query["id"].ToString());
        OnPropertyChanged(nameof(Id));

        Load(Id);
    }

    public CategoryContentViewModel(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [ObservableProperty]
    private Category _selectedCategory;

    [ObservableProperty]
    private List<Recipe> _recipes = new List<Recipe>();

    [RelayCommand]
    private void SelectRecipe(Guid id)
    {
        var navigationParameter = new ShellNavigationQueryParameters
        {
            { "id", id }
        };
        Shell.Current.GoToAsync("recipe", navigationParameter);
    }

    private void Load(Guid id)
    {
        var category = _dataContext
            .Categories.Include(c => c.Items)
            .ThenInclude(i => i.Recipe)
            .FirstOrDefault(category => category.Id == id);

        if (category != null)
        {
            SelectedCategory = category;

            Recipes = SelectedCategory?.Items
             .Select(i => i.Recipe)
            .OrderBy(r => r.Name)
            .ToList();
        }
    }
}
