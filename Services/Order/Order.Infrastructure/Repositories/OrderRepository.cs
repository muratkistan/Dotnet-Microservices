using Microsoft.EntityFrameworkCore;
using Order.Application.Repositories;
using Order.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OrderEntity = Order.Domain.Entities.Order;

namespace Order.Infrastructure.Repositories
{
    internal class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbSet
               .Where(o => o.UserName == userName)
               .ToListAsync();
            return orderList;
        }
    }
}