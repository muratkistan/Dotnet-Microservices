using MediatR;
using Order.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Features.Queries.Order.GetAllOrder
{
    public class GetAllOrderQuery : IRequest<List<OrderResponse>>
    {
        public string Username { get; set; } = default!;

        public GetAllOrderQuery(string username)
        {
            Username = username;
        }
    }
}