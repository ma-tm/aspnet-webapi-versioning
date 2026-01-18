namespace aspnet_webapi_versioning.ViewModels
{
    public class ApiResponse
    {
        public required OrderForm OrderForm { get; set; }
        public required string Version { get; set; }
    }
}
