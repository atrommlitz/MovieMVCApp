using Microsoft.AspNetCore.Mvc;
using MovieMVCApp.Models;
using System.Diagnostics;

namespace MovieMVCApp.Controllers
{
    //Use the home controller to to navigate through the views and use the move collection to post to the database
    public class HomeController : Controller
    {
        private MoviesCollectionContext _context;

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

        [HttpGet]
        public IActionResult MoviesCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MoviesCollection(MovieCollection response)
        {
            _context.MoviesCollection.Add(response); // Add record to the database
            _context.SaveChanges();
            return View("Index");
        }

        
    }
}
