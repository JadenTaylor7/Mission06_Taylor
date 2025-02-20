using Microsoft.EntityFrameworkCore;

namespace Mission06_Taylor.Models
{
    public class MovieTitlesContext : DbContext
    {
        public MovieTitlesContext(DbContextOptions<MovieTitlesContext> options) : base (options)
        {
        
        }

        public DbSet<Application> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Documentary" },
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Horror" },
                new Category { CategoryId = 6, CategoryName = "Musical" }
            );
        }
    }
}
