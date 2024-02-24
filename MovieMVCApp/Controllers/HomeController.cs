using Microsoft.AspNetCore.Mvc;
using MovieMVCApp.Models;
using System.Diagnostics;

namespace MovieMVCApp.Controllers
{
    //Use the home controller to to navigate through the views and use the move collection to post to the database
    public class HomeController : Controller
    {
        private MoviesCollectionContext _context;

        //Set up the views for our website to use

        public HomeController(MoviesCollectionContext temp) 
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetToKnow()
        {
            return View();
        }
        //Use the view bag to create a new movie collection object 
        [HttpGet]
        public IActionResult MoviesCollection()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View("MoviesCollection", new MovieCollection());

        }

        //Take the response from the movie collection form and add it to the database and then save the changes. Then return view to the homepage
        //Include a checker to make sure that the numbers input are valid 

        [HttpPost]
        public IActionResult MoviesCollection(MovieCollection response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to the database
                _context.SaveChanges();
                return View("Index", response);
            }
            else 
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }
        }
        //Take the information and pass it to the movie table view
        public IActionResult MovieTable()
        {
            var movies = _context.Movies.ToList();

            return View(movies);

        }

        //get the movie id from the database and allow changes to be made
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordtoEdit = _context.Movies
                .Single(x => x.MovieId == id );

            ViewBag.Categories = _context.Categories.ToList();

            return View("MoviesCollection", recordtoEdit);

        }

        //Update and save the changes to the table 
        [HttpPost]
        public IActionResult Edit(MovieCollection updatedinfo)
        {
            _context.Update(updatedinfo);
            _context.SaveChanges();

            return RedirectToAction("MovieTable");
        }

        //Allow to delete a record by grabbing the correct movie id

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        //Remove the movie and then update it 
        [HttpPost]
        public IActionResult Delete(MovieCollection application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("MovieTable");
        }

    }
}
