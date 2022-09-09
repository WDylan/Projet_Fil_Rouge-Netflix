using API_Netflix_ASPNetCore.Models.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Netflix_ASPNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : Controller
    {
        //private IWebHostEnvironment _env;
        //private IUpload _upload;

        //public UtilisateursController(IWebHostEnvironment env, IUpload upload)
        //{
        //    _env = env;
        //    _upload = upload;
        //}


        // GET: api/<UtilisateursController>
        [HttpGet]
        public IEnumerable<Utilisateurs> Get()
        {

            List<Utilisateurs> _utilisateursList = new();
            _utilisateursList = Utilisateurs.GetAll();
            return _utilisateursList;
        }

        //GET: api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public Utilisateurs Get(int id)
        {
            Utilisateurs utilisateur = new();
            utilisateur = Utilisateurs.Get(id);
            return utilisateur;
        }

        // POST: api/<UtilisateursController>/
        [HttpPost]
        public IActionResult Post([FromBody] Utilisateurs utilisateur)
        {
            utilisateur.Add();
            return Ok(new { message = "Utilisateur ajouté !", Utilisateur = utilisateur });
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Utilisateurs utilisateur)
        {
            Utilisateurs utilisateur2 = new Utilisateurs();
            utilisateur2 = utilisateur;
            utilisateur.Update();
            return Ok(new { message = "Utilisateur Modifié", Utilisateur = utilisateur });
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Utilisateurs utilisateur = new();
            utilisateur = Utilisateurs.Get(id);
            utilisateur.Delete();
            return Ok(new { message = "Utilisateur supprimé", Id = id });
        }

    }
}
