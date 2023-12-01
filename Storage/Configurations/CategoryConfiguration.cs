using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRecipes.Models;


namespace MRecipes.Storage.Configurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));

        builder.HasKey(c => c.Id);

        builder.HasMany(c => c.Items)
            .WithOne(i => i.Category)
            .HasForeignKey(c => c.CategoryId);
    }
}
