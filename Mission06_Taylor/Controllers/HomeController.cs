using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Taylor.Models;
//These are the asp actions
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



        [HttpGet] //add a movie
        public IActionResult EnterMovie()
        {

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("EnterMovie", new Application());
        }

        [HttpPost]
        public IActionResult EnterMovie(Application response)
        {
            if (ModelState.IsValid) //valid inputs
            {
                _context.Movies.Add(response); //Add record to the database
                _context.SaveChanges(); //Commits changes to database
                return View("Confirmation", response);
            }
            else //invalid inputs
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();
                return View(response);
            }

        }

        //Mission07 function (Waitlist)
        public IActionResult MovieCollection()
        {
            //todo: get CategoryName id to work
            //Linq
            
            var someMovies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Category.CategoryName).ToList();

            return View("MovieCollection", someMovies);
        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("EnterMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application response) 
        {
            _context.Update(response);
            _context.SaveChanges();
            return RedirectToAction("MovieCollection");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("DeleteConfirm", recordToDelete);
        }


        [HttpPost]
        public IActionResult Delete(Application destroyInfo)
        {
            _context.Remove(destroyInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieCollection");
        }

    }
}
