namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T response)
        {
            Data = response;
        }

        public T Data { get; set; }
    }
}