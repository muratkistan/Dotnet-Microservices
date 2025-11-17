using AutoMapper;
using Basket.Application.Features.Responses;
using Basket.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Features.Basket.Queries.GetBasket
{
    public class GetBasketByUserNameHandler : IRequestHandler<GetBasketByUserNameQuery, CartResponse>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public GetBasketByUserNameHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<CartResponse> Handle(GetBasketByUserNameQuery request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _basketRepository.GetBasket(request.UserName);

            if (shoppingCart == null)
            {
                return new CartResponse(request.UserName)
                {
                    Items = new List<CartItemResponse>()
                };
            }

            var shoppingCartResponse = _mapper.Map<CartResponse>(shoppingCart);
            return shoppingCartResponse;
        }
    }
}