using Microsoft.AspNetCore.Mvc;

namespace SharkWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
