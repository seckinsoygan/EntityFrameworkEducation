using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCodeFirstEducation.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Total).HasPrecision(5);
        }
    }
}
