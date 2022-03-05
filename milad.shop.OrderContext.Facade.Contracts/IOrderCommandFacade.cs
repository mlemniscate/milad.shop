using milad.shop.OrderContext.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Facade.Contracts
{
    public interface IOrderCommandFacade
    {
        void CreateOrder(CreateOrderCommand command);
    }
}
