using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_murdodav.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Mission06_murdodav.Controllers
{
    public class HomeController : Controller
    {

        // making a private MovieCollectionContext instance called _moviesContext with a getter and setter
        // (so that we can hook it up to our database)
        private MovieCollectionContext moviesContext { get; set; }

        // Constructor
        // (passing logger and the MoviesCollectionContext object to the constructor
        public HomeController(MovieCollectionContext movies_context)
        {
            // inserting that moviesContext object into the _moviesContext variable
            moviesContext = movies_context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult ViewMovies()
        {
            // putting the movieinfo (response) of the moviesContext table context object into a list of type "Movie"
            var MovieList = moviesContext.Movies
                // getting the Cateogry object associated with that movie (through the CategoryID FK relationship)
                .Include(x => x.Category)
                //making sure the movie hasn't been edited
                //.Where(x => x.Edited != true)
                // ordering by Title
                .OrderBy(x => x.MovieID)
                .ToList();


            // putting that MovieList into the View function as "context" for the page
            return View(MovieList);
        }

        [HttpGet]
        public IActionResult AddAMovie()
        {
            // Creating a ViewBag (dynamically created variables that can be seen across all the views and the controller)
            // getting the Categories object from the moviesContext file, turning that into a list, and then putting it into the ViewBag.Categories dynamic variable
            ViewBag.Categories = moviesContext.Categories.ToList();

            return View();
        }

        [HttpPost] // a post method that retrieves the AddAMovie form inputs as "ar
        public IActionResult AddAMovie(Movie ar)
        {
            // If the info in the form is valid...
            if (ModelState.IsValid)
            {
                // Proposing the changes using the form inputs (adding the data to the database)
                moviesContext.Add(ar);
                // saving the changes to the database
                moviesContext.SaveChanges();

                // returns you to the AddAMovie page (no confirmation page necessary for this assignment :) )
                return RedirectToAction();
            }
            // if the model/field is NOT valid...
            else
            {
                // bring them back to the form view
                return View();
            }
        }

        public IActionResult Podcasts()
        {
            return View();
        }
    }
}
