using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.PaymentMethod
{
    public class PaymentMethodResponse
    {
        public int Id { get; set; }
        public MethodOfPayment Method { get; set; }
    }
}