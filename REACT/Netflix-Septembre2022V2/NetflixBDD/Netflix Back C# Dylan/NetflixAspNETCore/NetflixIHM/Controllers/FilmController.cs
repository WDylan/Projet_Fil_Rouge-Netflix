using APINetflix.Models;
using Microsoft.AspNetCore.Mvc;
using NetflixIHM.Interface;
using System.Collections.Generic;

namespace NetflixIHM.Controllers
{
    public class FilmController : Controller
    {
        private IWebHostEnvironment _env;

        private IUpload _upload;

        public FilmController(IWebHostEnvironment env, IUpload upload)
        {
            _env = env;
            _upload = upload;
        }

        // GET: FilmController
        public ActionResult Index(string? search)
        {
            List<Films> = search == null ? Films.GetAll() : Films.SearchFilms(search);
            return View(film);
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            Films film = new();
            film = film.Get(id).Item2;
            return View(film);
        }

        // GET: ContactController/Create
        public IActionResult Form(int? id)
        {
            Films film = new();
            if (id != null)
            {
                ViewData["title"] = "Update Film";
                film = film.Get((int)id).Item2;
            }
            else
            {
                ViewData["title"] = "Add Film";
            }
            return View(film);
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitForm(Films film, IFormFile affiche)
        {
            if (film.IdFilm > 0)
            {
                film.Update();
            }
            else
            {
                film.Image = _upload.Upload(affiche);
                film.Add();
            }
            //on peut faire une redirection vers l'action index
            return RedirectToAction("Index", "Film");
        }

        public IActionResult ConfirmDelete(int id)
        {
            Films film = new();
            film = film.Get(id).Item2;
            return View(film);
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            Films film = new();
            film = film.Get(id).Item2;
            return View(film != null ? film.Delete().Item1 : false);
        }

    }
}
