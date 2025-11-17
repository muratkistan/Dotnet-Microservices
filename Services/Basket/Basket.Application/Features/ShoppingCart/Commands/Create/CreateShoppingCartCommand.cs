using Basket.Application.Features.Responses;
using Basket.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Features.ShoppingCart.Commands.Create
{
    public class CreateShoppingCartCommand : IRequest<CartResponse>
    {
        public string UserName { get; set; }
        public List<CartItem> Items { get; set; }

        public CreateShoppingCartCommand(string username, List<CartItem> items)
        {
            UserName = username;
            Items = items;
        }
    }
}