using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct
{
    public class CreateRequestImportProductResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public E.RequestImportProduct RequestImportProduct { get; set; }
    }
}