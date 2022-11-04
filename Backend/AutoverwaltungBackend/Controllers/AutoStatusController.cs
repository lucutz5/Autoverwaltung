using Microsoft.AspNetCore.Mvc;
using AutoverwaltungBackend.Models.Interfaces;
using AutoverwaltungBackend.Models.Classes;



namespace AutoverwaltungBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class AutoStatusController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]/{id}")]
        public IActionResult getAutoStatus(short id)
        {

            return new OkObjectResult(new AutoStatus());
        }
        [HttpPatch]
        [Route("[controller]/{id}")]
        public IActionResult updateAutoStatus(short id)
        {

            return new OkObjectResult(new AutoStatus());
        }
    }
}
