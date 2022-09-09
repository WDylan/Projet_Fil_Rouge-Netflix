using API_Netflix_ASPNetCore.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Netflix_ASPNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : Controller
    {
        //private IWebHostEnvironment _env;
        //private IUpload _upload;

        //public SeriesController(IWebHostEnvironment env, IUpload upload)
        //{
        //    _env = env;
        //    _upload = upload;
        //}

        // GET: api/<SeriesController>
        [HttpGet]
        public IEnumerable<Series> Get()
        {
            List<Series> seriesList = new();
            seriesList = Series.GetAll();
            return seriesList;
        }

        // GET: api/<SeriesController>/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
            Series serie = new();
            serie = Series.Get(id);
            return serie;
        }

        // POST: api/<SeriesController>/
        [HttpPost]
        public IActionResult Post([FromBody] Series serie)
        {
            serie.Add();
            return Ok(new { message = "Série ajoutée !", Serie = serie });
        }

        // PUT api/<SeriesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Series serie)
        {
            Series serie2 = new Series();
            serie = serie;
            serie.Update();
            return Ok(new { message = "Série Modifiée", Serie = serie });
        }

        // DELETE api/<SeriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Series serie = new();
            serie = Series.Get(id);
            serie.Delete();
            return Ok(new { message = "Série supprimée", Id = id });
        }
    }
}
