namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RatingImage
{
    public class RatingImageResponse
    {
        public int Id { get; set; }
        public string ImgLocation { get; set; }
        public string ImgName { get; set; }
        public int RatingId { get; set; }
        public int ProductTierId { get; set; }
    }
}