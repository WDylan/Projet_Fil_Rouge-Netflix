using API_Netflix_ASPNetCore.Models.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Netflix_ASPNetCore.Controllers
{
    public class UtilisateursController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        // GET: api/<FilmsController>
        [HttpGet]
        //public IEnumerable<Utilisateurs> Get()
        //{
        //    List<Utilisateurs> utilisateursList = new();
        //    utilisateursList = Utilisateurs.GetAll();
        //    return utilisateursList;
        //}

        // GET: api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public Utilisateurs Get(int id)
        {
            Utilisateurs utilisateur = new();
            utilisateur = utilisateur.Get(id).Item2;
            return utilisateur;
        }

        // GET: UtilisateursController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UtilisateursController/Create
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

        // GET: UtilisateursController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UtilisateursController/Edit/5
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

        // GET: UtilisateursController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UtilisateursController/Delete/5
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
