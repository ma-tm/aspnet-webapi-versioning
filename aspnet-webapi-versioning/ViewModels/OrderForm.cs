namespace aspnet_webapi_versioning.ViewModels
{
    public class OrderForm
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
}
