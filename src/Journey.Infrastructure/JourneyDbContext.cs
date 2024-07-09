using Microsoft.EntityFrameworkCore;
using Journey.Infrastructure.Entities;

namespace Journey.Infrastructure
{
    public class JourneyDbContext :DbContext
    {
        public DbSet<Trip> Trips { get; set; }

    }
}
