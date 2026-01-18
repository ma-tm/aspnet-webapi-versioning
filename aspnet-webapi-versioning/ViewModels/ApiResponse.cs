namespace aspnet_webapi_versioning.ViewModels
{
    public class ApiResponseV1
    {
        public required OrderFormV1 OrderForm { get; set; }
        public required string Version { get; set; }
    }

    public class ApiResponseV2
    {
        public required OrderFormV2 OrderForm { get; set; }
        public required string Version { get; set; }
    }
}
