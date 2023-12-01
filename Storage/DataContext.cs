using Microsoft.EntityFrameworkCore;
using MRecipes.Models;
using MRecipes.Storage.Utils;

namespace MRecipes.Storage;

public class DataContext : DbContext
{
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionDb = $"FileName={PathDB.GetPath()}";

        optionsBuilder.UseSqlite(connectionDb);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

        modelBuilder.Entity<Recipe>().HasData(Seed.Seed.GetRecipes());
        modelBuilder.Entity<Category>().HasData(Seed.Seed.GetCategories());
        modelBuilder.Entity<CategoryItem>().HasData(Seed.Seed.GetCategoryItems());

        base.OnModelCreating(modelBuilder);
    }
}
