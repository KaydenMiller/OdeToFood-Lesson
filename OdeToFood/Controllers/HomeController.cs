using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.Restaurant {
                Id = 1,
                Name = "Scott's Pizza Place"
            };

            return View(model);
            //return Content("Hello from the HomeController!");
        }
    }
}
