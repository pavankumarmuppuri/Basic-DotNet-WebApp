using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Action for the "Home" page
        public IActionResult Index()
        {
            return View(); // Returns the "Index.cshtml" view
        }

        // Action for the "About" page
        public IActionResult About()
        {
            return View(); // Returns the "About.cshtml" view
        }
        public IActionResult Privacy()
        {
            return View(); // Returns the "About.cshtml" view
        }
    }
}
