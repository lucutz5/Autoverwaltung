using Microsoft.AspNetCore.Mvc;

namespace AutoverwaltungBackend.Controllers
{
    [ApiController]
    [Route("api")]
    public class AutoStatusController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]/{id}")]
        public ActionResult<AutoStatus> getAutoStatus(short id)
        {

            return new OkObjectResult(new AutoStatus());
        }
        [HttpPatch]
        [Route("[controller]/{id}")]
        public ActionResult<AutoStatus> updateAutoStatus(short id)
        {

            return new OkObjectResult(new AutoStatus());
        }
    }
}
