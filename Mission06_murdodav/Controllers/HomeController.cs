using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;

        // making a private MovieCollectionContext instance called _moviesContext with a getter and setter
        // (so that we can hook it up to our database)
        private MovieCollectionContext moviesContext { get; set; }

        // Constructor
        // (passing logger and the MoviesCollectionContext object to the constructor
        public HomeController(ILogger<HomeController> logger, MovieCollectionContext movies_context)
        {
            _logger = logger;
            // inserting that moviesContext object into the _moviesContext variable
            moviesContext = movies_context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAMovie()
        {
            return View();
        }

        [HttpPost] // a post method that retrieves the AddAMovie form inputs as "ar
        public IActionResult AddAMovie(Movie ar)
        {
            // Proposing the changes using the form inputs
            moviesContext.Add(ar);
            // saving the changes to the database
            moviesContext.SaveChanges();

            // returns you to the AddAMovie page (no confirmation page necessary for this assignment :) )
            return RedirectToAction();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
