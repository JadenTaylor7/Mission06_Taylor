using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Taylor.Models;

namespace Mission06_Taylor.Controllers
{
    public class HomeController : Controller
    {
        private MovieTitlesContext _context;

        public HomeController(MovieTitlesContext someName) //Constructor
        {
            _context = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }


        [HttpPost]
        public IActionResult EnterMovie(Application response)
        {
            _context.Applications.Add(response); //Add record to the database
            _context.SaveChanges(); //Commits changes to database
            return View("Confirmation", response);
        }
    }
}
