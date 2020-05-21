namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage
{
    public class ProductImageResponse
    {
        public int Id { get; set; }
        public string ImgLocation { get; set; }
        public string ImgName { get; set; }
        public int ProductId { get; set; }
    }
}