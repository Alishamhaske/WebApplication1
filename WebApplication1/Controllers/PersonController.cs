using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
   
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {

            List<string> cities = new List<string>()
            {
                "pune","nagar","mumbai","goa"
            };
            ViewData["cities"] = new SelectList(cities);

            return View();
        }

        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form, ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Hobbies = hobbies;
            return View("DisplayDetails");
        }




    }

}
