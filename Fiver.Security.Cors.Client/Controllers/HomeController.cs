using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.Cors.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
