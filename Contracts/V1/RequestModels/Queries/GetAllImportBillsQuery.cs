using System;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllImportBillsQuery
    {
        public double FromAmount { get; set; }
        public double ToAmount { get; set; }
        public string Code { get; set; }
        // public DateTime FromCreatedDate { get; set; }
        // public DateTime ToCreatedDate { get; set; }
        public int RequestImportProductId { get; set; }
        public int StorageManagerId { get; set; }
        public int StorageId { get; set; }
    }
}