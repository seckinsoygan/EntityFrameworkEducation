using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstEducation.Model
{
    public class Deneme2Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Database2CodeFirst;Integrated Security=true");
        }

        public DbSet<Test> Seckins { get; set; }



    }
}
