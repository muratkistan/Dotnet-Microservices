using Basket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Domain.Repositories
{
    public interface IBasketRepository
    {
        Task<Cart> GetBasket(string userName);

        Task<Cart> UpdateBasket(Cart shoppingCart);

        Task DeleteBasket(string userName);
    }
}