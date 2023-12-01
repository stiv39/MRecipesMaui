using Microsoft.EntityFrameworkCore;
using MRecipes.Models;
using MRecipes.Storage.Utils;

namespace MRecipes.Storage;

public class DataContext : DbContext
{
    public DbSet<Recipe> Recipes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionDb = $"FileName={PathDB.GetPath()}";

        optionsBuilder.UseSqlite(connectionDb);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

        modelBuilder.Entity<Recipe>().HasData(GetRecipes());

        base.OnModelCreating(modelBuilder);
    }

    private static List<Recipe> GetRecipes() =>
           new()
           {
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Description = "Lorem impsum",
                    Name = "Recipe 1"
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Description = "Lorem impsum",
                    Name = "Recipe 2"
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Description = "Lorem impsum",
                    Name = "Recipe 3"
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Description = "Lorem impsum",
                    Name = "Recipe 4"
                },
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Description = "Lorem impsum",
                    Name = "Recipe 5"
                }
           };
}
