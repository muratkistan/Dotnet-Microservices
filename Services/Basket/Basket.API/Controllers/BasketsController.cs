using Basket.Application.Features.Basket.Commands.Delete;
using Basket.Application.Features.Basket.Queries.GetBasket;
using Basket.Application.Features.Responses;
using Basket.Application.Features.ShoppingCart.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Basket.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BasketsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{userName}")]
        [ProducesResponseType(typeof(CartResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CartResponse>> GetBasket(string userName)
        {
            var query = new GetBasketByUserNameQuery(userName);
            var basket = await _mediator.Send(query);
            return Ok(basket);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CartResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CartResponse>> CreateBasket([FromBody] CreateShoppingCartCommand command)
        {
            var basket = await _mediator.Send(command);
            return Ok(basket);
        }

        [HttpDelete("{userName}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> DeleteBasket(string userName)
        {
            var deleteCommand = new DeleteBasketByUserNameCommand(userName);
            var result = await _mediator.Send(deleteCommand);
            return Ok(result);
        }
    }
}