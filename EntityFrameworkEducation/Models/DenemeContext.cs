using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkEducation.Models
{
    public class DenemeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Database1;Integrated Security=true");
        }
        public DbSet<SimpleTable>? SimpleTables { get; set; }


    }
}
