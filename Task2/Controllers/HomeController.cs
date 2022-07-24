using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserAgent = HttpContext.Request.Headers["User-Agent"];
            ViewBag.Address = HttpContext.Connection.RemoteIpAddress;

            return View();
        }
    }
}
