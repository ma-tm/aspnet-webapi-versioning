using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [MapToApiVersion("2.0")]
        [HttpGet]
        public string Get()
        {
            return "Orders information from API v2";
        }
    }
}
