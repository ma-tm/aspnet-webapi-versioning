using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_versioning.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public string Get()
        {
            return "Order information from API v1";
        }
    }
}
