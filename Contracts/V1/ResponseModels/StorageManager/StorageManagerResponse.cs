using System;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager
{
    public class StorageManagerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public int StorageId { get; set; }
    }
}