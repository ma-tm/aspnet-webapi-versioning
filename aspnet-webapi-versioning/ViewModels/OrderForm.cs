namespace aspnet_webapi_versioning.ViewModels
{
    public class OrderFormV1
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public int ItemCount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; }
        public string PaymentStatus { get; set; }        
    }

    public class OrderFormV2 : OrderFormV1
    {
        // v2 properties
        public string ShippingAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}
