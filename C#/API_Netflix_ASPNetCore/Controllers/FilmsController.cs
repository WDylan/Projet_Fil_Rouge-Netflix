using API_Netflix_ASPNetCore.Interface;
using Microsoft.AspNetCore.Mvc;


namespace API_Netflix_ASPNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : Controller
    {
        //private IWebHostEnvironment _env;
        //private IUpload _upload;

        //public FilmsController(IWebHostEnvironment env, IUpload upload)
        //{
        //    _env = env;
        //    _upload = upload;
        //}


        // GET: api/<FilmsController>
        [HttpGet]
        public IEnumerable <Films> Get()
        {
            List<Films> _filmsList = new();
            _filmsList = Films.GetAll();
            return _filmsList;
        }

        // GET: api/<FilmsController>/5
        [HttpGet("{id}")]
        public Films Get(int id)
        {
            Films film = new();
            film = film.Get(id);
            if (film != null)
            {
                return film;
            }
            else
            {
                return null;
            }
        }

        // POST: api/<FilmsController>/
        //[HttpPost]
        //public IActionResult Post([FromBody] Films film)
        //{
        //    film.Add();
        //    return Ok(new { message = "Film ajouté !", Film = film });
        //}

        // PUT api/<FilmsController>/5
        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] Films film)
        //{
        //    id = film.IdFilm;
        //    return Ok(new { message = "Film Modifié", Film = film });
        //}

        // DELETE api/<FilmsController>/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    Films film = new();
        //    film = film.Get(id);
        //    film.Delete();
        //    return Ok(new { message = "Film supprimé", Id = id });
        //}

    }
}