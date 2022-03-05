using milad.Framework.Core.Application;
using milad.Framework.Facade;
using milad.shop.OrderContext.Application.Contracts;
using milad.shop.OrderContext.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Facade
{
    public class OrderCommandFacade : BaseCommandFacade, IOrderCommandFacade
    {
        public OrderCommandFacade(ICommandBus commandBus) : base(commandBus)
        {

        }

        public void CreateOrder(CreateOrderCommand command)
        {
            CommandBus.Dispatch(command);
        }
    }
}
