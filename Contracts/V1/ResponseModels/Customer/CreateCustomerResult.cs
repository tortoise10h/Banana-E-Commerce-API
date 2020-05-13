using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer
{
    public class CreateCustomerResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public CustomerResponse Customer { get; set; }

    }
}