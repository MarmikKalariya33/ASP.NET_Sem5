using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers // Folder Name And File Name 
{
    public class FirstController : Controller // Controller Name And Class Name 
    {
        public IActionResult Index() // Action Method Name
        {
            return View();
        }

        public IActionResult Name()
        {
            return View();
        }
    }
}