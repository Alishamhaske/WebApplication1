using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentDetails()
        {

            List<string> cities = new List<string>()
            {
                "pune","nagar","mumbai","goa"
            };
            ViewData["cities"] = new SelectList(cities);


            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form, ICollection<string> subject)
        {
            ViewBag.Id = form["id"];
            ViewBag.Name = form["name"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Subject = subject;
            return View("DisplayDetails");
        }

    }
}
