using Microsoft.EntityFrameworkCore;
using Mission06_Trommlitz.Models;

namespace MovieMVCApp.Models
{
    public class MoviesCollectionContext : DbContext
    {
        public MoviesCollectionContext(DbContextOptions<MoviesCollectionContext> options) : base (options) 
        { 
        }

        public DbSet<MovieCollection> Movies { get; set; }
        public DbSet<Category> Categories {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                ) ;
        }
    }
}
