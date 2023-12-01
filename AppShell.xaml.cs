using MRecipes.Views;

namespace MRecipes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("mainpage", typeof(MainPage));
            Routing.RegisterRoute("category", typeof(CategoryContentView));
            Routing.RegisterRoute("category/recipe", typeof(RecipeContentView));
        }
    }
}
