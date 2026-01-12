using MediatR;
using Microsoft.Extensions.Logging;
using Order.Application.Exceptions;
using Order.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Features.Commands.Order.DeleteOrder
{
    internal class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<DeleteOrderCommandHandler> _logger;

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToDelete = await _orderRepository.GetByIdAsync(request.Id);
            if (orderToDelete == null)
            {
                throw new OrderNotFoundException(request.Id);
            }
            var result = await _orderRepository.DeleteAsync(request.Id);
            if (result)
                _logger.LogInformation($"Order is deleted successfully. => {request.Id}");
            return result;
        }
    }
}