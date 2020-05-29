using System.Collections.Generic;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill
{
    public class CheckValidImportBillDetailQuantityResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
    }
}