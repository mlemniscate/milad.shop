using milad.shop.CustomerContext.Application.Contracts.Customers;

namespace milad.shop.CustomerContext.Facade.Contracts
{
    public interface ICustomerCommandFacade
    {
        void Signup(SignupCommand command);
    } 
}
