using Asp.Versioning;
using aspnet_webapi_versioning.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
                PaymentStatus = "paid"
            };
            var json = JsonConvert.SerializeObject(order, Formatting.Indented);
            return $"Orders information from API v1 : {json}";
        }

        [MapToApiVersion("1.0")]
        [HttpPost]
        public string Post([FromForm] OrderForm requestForm)
        {
            var json = JsonConvert.SerializeObject(requestForm);
            return $"Post from API v1 : {json}";
        }

        [MapToApiVersion("1.0")]
        [HttpPut]
        public string Put(int? orderId)
        {
            if (orderId.HasValue)
            {
                return $"Put from API v1, Order ID: {orderId}";
            }
            return "Put Orders information from API v1";
        }

        [MapToApiVersion("1.0")]
        [HttpDelete]
        public string Delete(int? orderId)
        {
            if (orderId.HasValue)
            {
                return $"Delete from API v1, Order ID: {orderId}";
            }
            return "Delete Orders information from API v1";
        }
    }
}
