using Microsoft.EntityFrameworkCore;

namespace Beauty_salon.Data
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqlocaldb;Database=master;Trusted_Connection=True");
        }
    }
}
