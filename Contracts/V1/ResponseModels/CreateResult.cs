using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels
{
    public class CreateResult<T>
    {
        public CreateResult()
        {

        }

        public CreateResult(
            bool isSuccess,
            List<string> errors,
            T entity
        )
        {
            IsSuccess = isSuccess;
            Errors = errors;
            EntityReturn = entity;
        }

        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public T EntityReturn { get; set; }
    }
}