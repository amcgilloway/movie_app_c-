using System;
using Microsoft.EntityFrameworkCore;

namespace MvcMovies.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovies.Models.Movie> Movie { get; set; }
    }
}
