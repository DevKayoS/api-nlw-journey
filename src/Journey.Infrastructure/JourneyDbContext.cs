using Microsoft.EntityFrameworkCore;
using Journey.Infrastructure.Entities;

namespace Journey.Infrastructure
{
    public class JourneyDbContext :DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\JourneyDatabase.db");
        }
    }
}
