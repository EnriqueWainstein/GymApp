using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.MVC.Controllers
{
    public class ControladorEntrenador : Controller
    {
        // GET: ControladorEntrenador
        public ActionResult Index()
        {
            return View();
        }

        // GET: ControladorEntrenador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControladorEntrenador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControladorEntrenador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorEntrenador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControladorEntrenador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControladorEntrenador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControladorEntrenador/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
