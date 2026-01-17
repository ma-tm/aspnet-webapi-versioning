using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_versioning.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public string Get()
        {
            return "Orders information from API v1";
        }
    }
}
