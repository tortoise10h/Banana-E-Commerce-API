using E = Banana_E_Commerce_API.Entities;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill
{
    public class CreateImportBillResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public E.ImportBill ImportBill { get; set; }
    }
}