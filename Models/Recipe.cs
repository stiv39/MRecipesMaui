namespace MRecipes.Models;

public class Recipe
{
    public Guid Id { get; set; }
    public string ShortName { get; set; } = string.Empty;
    public string LongName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Guide { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public ICollection<Ingredient> Ingredients { get; set; }
}
