using MRecipes.Services;
using MRecipes.ViewModels;

namespace MRecipes.Views;

public partial class CategoryContentView : ContentPage
{
	private readonly CategoryContentViewModel _viewModel;
	public CategoryContentView()
	{
		InitializeComponent();
		_viewModel = ServiceHelper.GetRequiredService<CategoryContentViewModel>();
		BindingContext = _viewModel;
	}
}