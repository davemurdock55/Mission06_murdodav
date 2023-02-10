using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_murdodav.Models
{
    // ":" means inheritance
    public class MovieCollectionContext : DbContext
    {
        // Constructor
        // passing some DbContextOptions for the MovieCollectionContext as options, which inherit from the base options type
        public MovieCollectionContext (DbContextOptions<MovieCollectionContext> options) : base (options)
        {
            // leave blank for now
        }

        // Getting a set of data of type "Movie" from our database called "movieinfo"
        public DbSet<Movie> movieinfo { get; set; }
    }
}
