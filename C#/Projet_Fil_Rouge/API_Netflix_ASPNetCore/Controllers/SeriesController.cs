
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Netflix_ASPNetCore.Controllers
{
    public class SeriesController : Controller
    {
        private IWebHostEnvironment _env;
        private IUpload _upload;

        public SeriesController(IWebHostEnvironment env, IUpload upload)
        {
            _env = env;
            _upload = upload;
        }


        // GET: SeriesController
        public ActionResult Index(string? search)
        {
            List<Series> series = search == null ? Series.GetAll() : Series.SearchFilm(search);
            return View(series);
        }


        // GET: SeriesController/Details/5
        public ActionResult Details(int id)
        {
            Series serie = new();
            serie = serie.Get(id).Item2;
            return View(serie);
        }

        // GET: SeriesController/Create
        public IActionResult Form(int? id)
        {
            Series serie = new();
            if (id != null)
            {
                ViewData["title"] = "Serie modifiée";
                serie = serie.Get((int)id).Item2;
            }
            else
            {
                ViewData["title"] = "Serie ajoutée";
            }
            return View(serie);
        }

        // POST: SeriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitForm(Series serie, IFormFile avatar)
        {
            if (serie.IdSerie > 0)
            {
                serie.Update();
            }
            else
            {
                serie.Image = _upload.Upload(avatar);
                serie.Add();
            }
            //on peut faire une redirection vers l'action index
            return RedirectToAction("Index", "Series");
        }

        // GET: SeriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeriesController/Edit/5
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

        public IActionResult ConfirmDelete(int id)
        {
            Series serie = new();
            serie = serie.Get(id).Item2;
            return View(serie);
        }

        // GET: SeriesController/Delete/5
        public ActionResult Delete(int id)
        {
            Series serie = new Series();
            serie = serie.Get(id).Item2;
            return View(serie != null ? serie.Delete() : false);
        }
    }
}