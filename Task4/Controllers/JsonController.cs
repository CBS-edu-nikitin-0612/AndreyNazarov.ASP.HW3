using Microsoft.AspNetCore.Mvc;

namespace Task4.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ClientInfo()
        {
            Client[] clients = new Client[]
            {
                new Client(){Id = 1, Login = "user1", Email = "user1@example.com"},
                new Client(){Id = 2, Login = "user2", Email = "user2@example.com"},
                new Client(){Id = 3, Login = "user3", Email = "user3@example.com"}
            };
            // Json - Сериализует объект переданный в параметрах в JSON и возвращает клиенту ответ.
            return Json(clients);
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
