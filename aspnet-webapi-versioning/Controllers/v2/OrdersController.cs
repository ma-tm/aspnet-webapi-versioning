using Asp.Versioning;
using aspnet_webapi_versioning.ViewModels;
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

        [MapToApiVersion("2.0")]
        [HttpPost]
        public string Post([FromForm] OrderForm requestForm)
        {
            if (requestForm.Quantity.HasValue && requestForm.ProductId.HasValue)
            {
                return $"Post from API v2, Product ID: {requestForm.Quantity.Value}, Quantity: {requestForm.ProductId.Value}";
            }
            return "Post Orders information from API v2";
        }

        [MapToApiVersion("2.0")]
        [HttpPut]
        public string Put(int? orderId)
        {
            if (orderId.HasValue)
            {
                return $"Put from API v2, Order ID: {orderId}";
            }
            return "Put Orders information from API v2";
        }

        [MapToApiVersion("2.0")]
        [HttpDelete]
        public string Delete(int? orderId)
        {
            if (orderId.HasValue)
            {
                return $"Delete from API v2, Order ID: {orderId}";
            }
            return "Delete Orders information from API v2";
        }
    }
}
