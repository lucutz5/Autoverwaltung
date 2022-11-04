using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoverwaltungBackend.Models.Interfaces;
using AutoverwaltungBackend.Models.Classes;


namespace AutoverwaltungBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class AutoController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public IEnumerable<IAuto> getAll()
        {
            return new Auto[] { new Auto() };
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public IAuto getById(short id)
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
