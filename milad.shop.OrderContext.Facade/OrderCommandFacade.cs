using milad.Framework.Core.Application;
using milad.Framework.Facade;
using milad.shop.CustomerContext.Application.Contracts.Customers;
using milad.shop.OrderContext.Application.Contracts;
using milad.shop.OrderContext.Domain.Contracts.Customers;
using milad.shop.OrderContext.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace milad.shop.OrderContext.Facade
{
    public class OrderCommandFacade : BaseCommandFacade, IOrderCommandFacade
    {
        public OrderCommandFacade(ICommandBus commandBus) : base(commandBus)
        {

        }

        public void CreateOrder(CreateOrderCommand command)
        {
            // TODO: Check that this is a true way of using scope or not.
            using (var scope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                EventBus.Subscribe<OrderCreatedEvent>(e => CommandBus.Dispatch(new UpdateScoreCommand(command.CustomerId, e.CustomerScore)));
                CommandBus.Dispatch(command);
                scope.Complete();
            }
        }
    }
}
