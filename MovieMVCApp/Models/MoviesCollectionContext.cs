using Microsoft.EntityFrameworkCore;

namespace MovieMVCApp.Models
{
    public class MoviesCollectionContext : DbContext
    {
        public MoviesCollectionContext(DbContextOptions<MoviesCollectionContext> options) : base (options) 
        { 
        }

        public DbSet<MovieCollection> MoviesCollection { get; set; }
    }
}
