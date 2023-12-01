﻿namespace MRecipes.Models;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<CategoryItem> Items { get; set; }
}
