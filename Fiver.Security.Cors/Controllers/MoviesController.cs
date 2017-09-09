using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.Cors.Controllers
{
    [Route("movies")]
    //[EnableCors("fiver")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Content("List of Movies");
        }

        [HttpGet("{id}")]
        //[DisableCors]
        public IActionResult Get(int id)
        {
            return Content($"Movie {id}");
        }
    }
}
