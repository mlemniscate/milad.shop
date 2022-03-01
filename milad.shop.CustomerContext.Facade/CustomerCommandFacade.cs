using milad.Framework.Core.Application;
using milad.Framework.Core.DependencyInjection;
using milad.Framework.Facade;
using milad.shop.CustomerContext.Application.Contracts.Customers;
using milad.shop.CustomerContext.Application.Customers;
using milad.shop.CustomerContext.Facade.Contracts;

namespace milad.shop.CustomerContext.Facade
{
    public class CustomerCommandFacade : BaseCommandFacade, ICustomerCommandFacade
    {

        public CustomerCommandFacade(ICommandBus commandBus) : base(commandBus)
        {
        }

        public void Signup(SignupCommand command)
        {
            CommandBus.Dispatch(command);
        }
    }
}
