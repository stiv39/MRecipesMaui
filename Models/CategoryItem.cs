namespace MRecipes.Models;

public class CategoryItem
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
