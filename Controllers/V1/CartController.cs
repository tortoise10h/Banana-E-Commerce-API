using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Cart;
using Microsoft.AspNetCore.Mvc;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class CartController : ControllerBase
    {
        [HttpPost(ApiRoutes.Cart.AddToCart)]
        public IActionResult AddToCart([FromBody] AddToCartRequest model)
        {
            return Ok();
        }
    }
}