using Microsoft.EntityFrameworkCore;

namespace Mission06_Taylor.Models
{
    public class MovieTitlesContext : DbContext
    {
        public MovieTitlesContext(DbContextOptions<MovieTitlesContext> options) : base (options)
        {
        
        }

        public DbSet<Application> Applications { get; set; }
    }
}
