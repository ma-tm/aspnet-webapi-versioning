using Asp.Versioning;
using aspnet_webapi_versioning.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aspnet_webapi_versioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [MapToApiVersion("2.0")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var order = new OrderForm
            {
                OrderId = "ORD-100245",
                OrderDate = DateTime.UtcNow,
                CustomerId = "CUST-78901",
                CustomerName = "Tom Hanks",
                Status = "confirmed",
                ItemCount = 3,
                Subtotal = 141.97m,
                Tax = 11.36m,
                TotalAmount = 153.33m,
                Currency = "USD",
                PaymentStatus = "paid",
            };
            var apiResponse = new
            {
                version = "v2",
                data = order
            };            
            return Ok(apiResponse);
        }

        [MapToApiVersion("2.0")]
        [HttpPost]
        public string Post([FromForm] OrderForm requestForm)
        {
            var json = JsonConvert.SerializeObject(requestForm);
            return $"Post from API v2 : {json}";
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
