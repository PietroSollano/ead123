using Microsoft.AspNetCore.Mvc;

namespace meu_projeto_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}