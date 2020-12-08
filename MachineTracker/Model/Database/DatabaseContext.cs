using Microsoft.EntityFrameworkCore;

namespace MachineTracker
{
    /// <summary>
    /// Context for the application database
    /// </summary>
    class DatabaseContext : DbContext
    {
        // public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
