using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            ViewData["message"] = "This is sample text in viewdata names";
            List<string> names = new List<string>()
            {
                "Akshay","Amol","Tushar","Vivek","Kishor"
            };
            ViewData["list"] = names; // implict --> object
            //return View();
             


            //
            ViewData["message2"] = "This is sample text in viewdata cities";
            List<string> cities = new List<string>()
            {
                "pune","nagar","mumbai","goa","satara"
            };
            ViewData["list2"] = cities; // implict --> object

            /* view bag*/

            ViewBag.Year = 2023;
            ViewBag.Month = "oct";
            ViewBag.Names = names;
            ViewBag.Name = "alisha";
            // ViewBag.cities = cities;

            TempData["company"] = "Think Quotient";
            TempData.Keep("company");

        
            
            
            return View();

        }

        public IActionResult Privacy()
        {
            var name = TempData["company"];
         //   TempData.Clear();
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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