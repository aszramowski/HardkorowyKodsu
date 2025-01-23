using Microsoft.AspNetCore.Mvc;

namespace HardkorowyKodsu.WebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly Version _version = new Version(1, 1, 1, 5);

        [HttpGet]
        public ActionResult<Version> GetVersion()
        {
            return Ok(_version);
        }
    }
}
