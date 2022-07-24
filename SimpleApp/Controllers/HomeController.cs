using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public FileStreamResult Download()
        {
            FileStream stream =  new FileStream(@"Files\001.Introduction.pdf",FileMode.Open);
            return File(stream, "application/pdf");
        }
    }
}
