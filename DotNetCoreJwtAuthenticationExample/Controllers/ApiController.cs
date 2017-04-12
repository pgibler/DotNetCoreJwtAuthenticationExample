using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreJwtAuth.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        // GET api/app
        [HttpGet]
        [Route("get_values")]
        [Authorize]
        public string Get()
        {
            return "Congratulations, you were authorized to use this service.";
        }
    }
}
