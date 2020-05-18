using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin
{
    public class AdminResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }
}