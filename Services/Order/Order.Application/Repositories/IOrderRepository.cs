using Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEntity = Order.Domain.Entities.Order;

namespace Order.Application.Repositories
{
    public interface IOrderRepository : IGenericRepository<OrderEntity>
    {
        Task<IEnumerable<OrderEntity>> GetOrdersByUserName(string userName);
    }
}