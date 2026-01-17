namespace aspnet_webapi_versioning.ViewModels
{
    public class OrderForm
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; } = default!;
        public int? Quantity { get; set; }
    }
}
