using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [MapToApiVersion("2.0")]
        [HttpGet]
        public string Get()
        {
            return "Order information from API v2";
        }
    }
}
