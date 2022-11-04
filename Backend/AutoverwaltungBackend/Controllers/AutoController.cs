using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AutoverwaltungBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class AutoController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public IEnumerable<Auto> getAll()
        {
            return new Auto[0];
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public Auto getById(short id)
        {
            return new Auto();
        }

        [HttpPut]
        [Route("[controller]")]
        public IActionResult addAuto([FromBody]Auto auto)
        {
            return new OkObjectResult(auto);
        }

        [HttpDelete]
        [Route("[controller]")]
        public IActionResult deleteAuto(short id)
        {
            return new OkObjectResult(new Auto());
        }

    }
}
