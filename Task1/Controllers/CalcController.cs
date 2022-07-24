using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int left, int right)
        {
            return View("Index", left + right);
        }

        [HttpPost]
        public IActionResult Sub(int left, int right)
        {
            return View("Index", left - right);
        }
        [HttpPost]
        public IActionResult Div(int left, int right)
        {
            return View("Index", left / right);
        }
        [HttpPost]
        public IActionResult Mul(int left, int right)
        {
            return View("Index", left * right);
        }
    }
}
