using Microsoft.EntityFrameworkCore;

namespace Beauty_salon.Data
{
    internal class DataContext:DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Services> Services { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqlocaldb;Database=BeautySalon;Trusted_Connection=True");
        }
    }
}
