using MRecipes.Models;

namespace MRecipes.Storage.Seed;

public static class Seed
{
    public static List<Category> GetCategories() =>
        new()
        {
        new Category
        {
            Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            Name = "Category 1",
            Image = "soups.png"
        },
        new Category
        {
            Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            Name = "Category 2",
            Image = "salads.png"
        },
        new Category
        {
            Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            Name = "Category 3",
            Image = "lunch.png"
        },
        new Category
        {
            Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            Name = "Category 4",
            Image = "pizza.jpg"
        },
        new Category
        {
            Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            Name = "Category 5",
            Image = "desserts.png"
        }
        };

    public static List<Recipe> GetRecipes() =>
        new()
        {
        new Recipe
        {
            Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            Description = "Lorem ipsum 1",
            Guide = "Step 1 ...",
            ShortName = "Recipe 1",
            LongName = "Recipe 1 Long Name",
            Image = "pizza.jpg"
        },
        new Recipe
        {
            Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            Description = "Lorem ipsum 2",
            Guide = "Step 1 ...",
            ShortName = "Recipe 2",
            LongName = "Recipe 2 Long Name",
            Image = "spaghetti.jpg"
        },
        new Recipe
        {
            Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
            Description = "Lorem ipsum 3",
            Guide = "Step 1 ...",
            ShortName = "Recipe 3",
            LongName = "Recipe 3 Long Name",
            Image = "sushi.png"
        },
        new Recipe
        {
            Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
            Description = "Lorem ipsum 4",
            Guide = "Step 1 ...",
            ShortName = "Recipe 4",
            LongName = "Recipe 4 Long Name",
            Image = "tiramisu.png"
        },
        new Recipe
        {
            Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
            Description = "Lorem ipsum 5",
            Guide = "Step 1 ...",
            ShortName = "Recipe 5",
            LongName = "Recipe 5 Long Name",
            Image = "chilli.png"
        }
        };

    public static List<CategoryItem> GetCategoryItems() =>
        new List<CategoryItem>
        {
            new CategoryItem
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                RecipeId = Guid.Parse("66666666-6666-6666-6666-666666666666")
            },
            new CategoryItem
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                RecipeId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")
            },
            new CategoryItem
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                RecipeId = Guid.Parse("99999999-9999-9999-9999-999999999999")
            },
            new CategoryItem
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                RecipeId = Guid.Parse("77777777-7777-7777-7777-777777777777")
            },
            new CategoryItem
            {
                Id = Guid.NewGuid(),
                CategoryId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                RecipeId = Guid.Parse("88888888-8888-8888-8888-888888888888")
            },
        };

    public static List<Ingredient> GetIngredients() =>
       new List<Ingredient>
       {
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 1",
                RecipeId = Guid.Parse("66666666-6666-6666-6666-666666666666")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 2",
                RecipeId = Guid.Parse("66666666-6666-6666-6666-666666666666")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 3",
                RecipeId = Guid.Parse("66666666-6666-6666-6666-666666666666")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 1",
                RecipeId = Guid.Parse("77777777-7777-7777-7777-777777777777")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 2",
                RecipeId = Guid.Parse("77777777-7777-7777-7777-777777777777")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 1",
                RecipeId = Guid.Parse("88888888-8888-8888-8888-888888888888")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 2",
                RecipeId = Guid.Parse("88888888-8888-8888-8888-888888888888")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 1",
                RecipeId = Guid.Parse("99999999-9999-9999-9999-999999999999")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 2",
                RecipeId = Guid.Parse("99999999-9999-9999-9999-999999999999")
            },
                        new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 1",
                RecipeId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")
            },
            new Ingredient
            {
                Id = Guid.NewGuid(),
                Name = "Ingredient 2",
                RecipeId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")
            }
       };
}
