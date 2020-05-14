namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Storage
{
    public class StorageResponse
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Size { get; set; }
        public string SizeUnit { get; set; }
        public string Name { get; set; }
    }
}