using Microsoft.AspNetCore.Mvc;

namespace GymApp.MVC.Controllers
{
    public class ControladorEntrenador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
