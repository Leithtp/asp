using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User(int id)
        {
            return View(id);
        }


    }
}
