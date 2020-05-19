namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address
{
    public class AddressResponse
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string StreetLocation { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int CustomerId { get; set; }
    }
}