namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllCategoriesQuery
    {
        public int CreatedBy { get; set; }
        public string Name { get; set; }
    }
}