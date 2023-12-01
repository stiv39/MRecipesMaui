using CommunityToolkit.Mvvm.ComponentModel;
using MRecipes.Models;
using MRecipes.Storage;

namespace MRecipes.ViewModels;

public partial class RecipeContentViewModel : ObservableObject, IQueryAttributable
{
    private Guid Id { get; set; }
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Id = Guid.Parse(query["id"].ToString());
        OnPropertyChanged(nameof(Id));

        Load(Id);
    }

    private readonly DataContext _dataContext;

    public RecipeContentViewModel(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [ObservableProperty]
    private Recipe _selectedRecipe;

    private void Load(Guid id)
    {
        SelectedRecipe = _dataContext.Recipes.FirstOrDefault(r => r.Id == id);
    }
}
