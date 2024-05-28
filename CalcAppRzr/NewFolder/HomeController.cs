using Microsoft.AspNetCore.Mvc;

namespace CalcAppRzr.NewFolder
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
