using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstEducation.Model
{
    public class Deneme2Context : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Database2CodeFirst;Integrated Security=true");
        //}

        public Deneme2Context(DbContextOptions<Deneme2Context> options) : base(options)
        {


        }

        public DbSet<Test> Seckins { get; set; }
        public DbSet<Product> Urunler { get; set; }

        public DbSet<Category> Kategoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductId).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Product>()
                .Property(p => p.Name).IsRequired().HasColumnName("ProductName").HasColumnType("varchar(100)");
            modelBuilder.Entity<Product>()
                .Property(p => p.Price).IsRequired().HasColumnType("money");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        }



    }
}
