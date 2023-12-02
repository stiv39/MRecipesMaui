using MRecipes.Views;

namespace MRecipes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("//mainpage", typeof(MainPage));
            Routing.RegisterRoute("//mainpage/category", typeof(CategoryContentView));
            Routing.RegisterRoute("//mainpage/category/recipe", typeof(RecipeContentView));
        }
    }
}
