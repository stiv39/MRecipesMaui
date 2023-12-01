using MRecipes.Services;
using MRecipes.ViewModels;

namespace MRecipes;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel;

    public MainPage()
    {
        InitializeComponent();
        
        _viewModel = ServiceHelper.GetRequiredService<MainPageViewModel>();
        
        BindingContext = _viewModel;
    }
}
