using AutoMapper;
using Basket.Application.Features.Responses;
using Basket.Domain.Entities;
using Basket.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Features.ShoppingCart.Commands.Create
{
    public class CreateShoppingCartCommandHandler : IRequestHandler<CreateShoppingCartCommand, CartResponse>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public CreateShoppingCartCommandHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<CartResponse> Handle(CreateShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _basketRepository.UpdateBasket(new Cart
            {
                UserName = request.UserName,
                Items = request.Items
            });
            var shoppingCartResponse = _mapper.Map<CartResponse>(shoppingCart);
            return shoppingCartResponse;
        }
    }
}