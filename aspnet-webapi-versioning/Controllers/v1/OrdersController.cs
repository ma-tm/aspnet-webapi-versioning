using Asp.Versioning;
using aspnet_webapi_versioning.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_webapi_versioning.Controllers.v1
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController() { }

        [MapToApiVersion("1.0")]
        [HttpGet]
        public string Get()
        {
            return "Orders information from API v1";
        }

        [MapToApiVersion("1.0")]
        [HttpPost]
        public string Post([FromForm] OrderForm requestForm)
        {
            if (requestForm.Quantity.HasValue && requestForm.ProductId.HasValue) {
                return $"Post from API v1, Product ID: {requestForm.Quantity.Value}, Quantity: {requestForm.ProductId.Value}";
            }
            return "Post Orders information from API v1";
        }

        [MapToApiVersion("1.0")]
        [HttpPut]
        public string Put(int? orderId)
        {
            if (orderId.HasValue) {
                return $"Put from API v1, Order ID: {orderId}";
            }
            return "Put Orders information from API v1";
        }

        [MapToApiVersion("1.0")]
        [HttpDelete]
        public string Delete(int? orderId)
        {
            if (orderId.HasValue) {
                return $"Delete from API v1, Order ID: {orderId}";
            }
            return "Delete Orders information from API v1";
        }
    }
}
