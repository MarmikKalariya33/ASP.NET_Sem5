using Microsoft.AspNetCore.Mvc;

namespace MVC.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
