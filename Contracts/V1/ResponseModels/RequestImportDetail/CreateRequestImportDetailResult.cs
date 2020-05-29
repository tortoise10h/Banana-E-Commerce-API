using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail
{
    public class CreateRequestImportDetailResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public E.RequestImportDetail RequestImportDetail { get; set; }
    }
}