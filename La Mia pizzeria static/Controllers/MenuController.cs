using Microsoft.AspNetCore.Mvc;

namespace La_Mia_pizzeria_static.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
