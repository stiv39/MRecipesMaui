using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRecipes.Models;


namespace MRecipes.Storage.Configurations;

public class CategoryItemConfiguration : IEntityTypeConfiguration<CategoryItem>
{
    public void Configure(EntityTypeBuilder<CategoryItem> builder)
    {
        builder.ToTable(nameof(CategoryItem));

        builder.HasKey(ci => ci.Id);
    }
}
