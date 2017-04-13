using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreJwtAuth.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        // GET api/service
        [HttpGet]
        [Route("service")]
        [Authorize]
        public string Get()
        {
            return "Congratulations, you were authorized to use this service.";
        }
    }
}
