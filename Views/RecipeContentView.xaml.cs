using MRecipes.Services;
using MRecipes.ViewModels;

namespace MRecipes.Views;

public partial class RecipeContentView : ContentPage
{
	private readonly RecipeContentViewModel _viewModel;
	public RecipeContentView()
	{
		InitializeComponent();
		_viewModel = ServiceHelper.GetService<RecipeContentViewModel>();
		BindingContext = _viewModel;
	}
}