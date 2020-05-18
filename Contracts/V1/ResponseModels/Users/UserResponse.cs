using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Manager;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Role;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Shipper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }

        public AdminResponse Admin { get; set; }
        public CustomerResponse Customer { get; set; }
        public StorageManagerResponse StorageManager { get; set; }
        public ManagerResponse Manager { get; set; }
        public ShipperResponse Shipper { get; set; }
        public RoleResponse Role { get; set; }
        public UserStatus Status { get; set; }
    }
}