using Microsoft.EntityFrameworkCore;

namespace MachineTracker
{
    /// <summary>
    /// Context for the application database
    /// </summary>
    class DatabaseContext : DbContext
    {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<ServiceHistory> ServiceHistories { get; set; }
        public DbSet<MachineLife> MachineLives { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
