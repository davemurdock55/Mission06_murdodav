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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }


        // a method that runs when the database is being created
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(

                new Category {CategoryID = 1, CategoryName = "Action/Adventure"},

                new Category { CategoryID = 2, CategoryName = "Comedy" },

                new Category { CategoryID = 3, CategoryName = "Drama" },

                new Category { CategoryID = 4, CategoryName = "Family" },

                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },

                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },

                new Category { CategoryID = 7, CategoryName = "Television" },

                new Category { CategoryID = 8, CategoryName = "VHS" },

                new Category { CategoryID = 9, CategoryName = "N/A" }

                );

            // making the new database with pre-filled-in data
            mb.Entity<Movie>().HasData(
                    // Seeding the database

                    // Adding Star Wars
                    new Movie
                    {
                        MovieID = 1,
                        CategoryID = 1,
                        Title = "Star Wars: A New Hope",
                        Year = 1977,
                        Director = "George Lucas",
                        Rating = "PG",
                        Edited = false,
                        LentTo = null,
                        Notes = "This is the unedited v.",
                    },

                    // Adding LEGO Batman
                    new Movie
                    {
                        MovieID = 2,
                        CategoryID = 4,
                        Title = "LEGO Batman",
                        Year = 2017,
                        Director = "Chris McKay",
                        Rating = "PG",
                        Edited = false,
                        LentTo = null,
                        Notes = "Lots of fun!",
                    },

                    // Adding She's the Man
                    new Movie
                    {
                        MovieID = 3,
                        CategoryID = 2,
                        Title = "She's the Man",
                        Year = 2006,
                        Director = "Andy Fickman",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = null,
                        Notes = "This is a good one!",
                    }

                );
        }
    }
}
