using Microsoft.AspNetCore.Mvc;
using Task5.Model;

namespace Task5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Типиззация работает, intellisense работает.
            // Так и должно быть что при использовании строготипизированного представления я могу в него передать любую модель, или должны быть ошибка на этапе компиляции?
            return View(DataInitializer.GetProducts());
        }

        public IActionResult Index2()
        {
            // Не работает типизация так как мы используем Dynamic, легче ошибиться, не работает intellisense
            ViewBag.Model = DataInitializer.GetProducts();
            return View();
        }
    }
}
