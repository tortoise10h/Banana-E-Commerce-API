namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating
{
    public class UpdateRatingRequest
    {
        public int StarNum { get; set; }
        public string Comment { get; set; }
    }
}