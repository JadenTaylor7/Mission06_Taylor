using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Taylor.Models;

namespace Mission06_Taylor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            return View("Confirmation", response);
        }
    }
}
