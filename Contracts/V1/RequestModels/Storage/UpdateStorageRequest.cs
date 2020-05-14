namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage
{
    public class UpdateStorageRequest
    {
        public string Location { get; set; }
        public double Size { get; set; }
        public string SizeUnit { get; set; }
        public string Name { get; set; }
    }
}