using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Netflix_ASPNetCore.Controllers
{
    public class FilmsController : Controller
    {
        // GET: FilmsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FilmsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FilmsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmsController/Create
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

        // GET: FilmsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmsController/Edit/5
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

        // GET: FilmsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FilmsController/Delete/5
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
