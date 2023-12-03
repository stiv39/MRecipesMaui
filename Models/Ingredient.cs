namespace MRecipes.Models;

public class Ingredient
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
