using milad.Framework.Application;
using milad.shop.CustomerContext.Application.Contracts.Customers;
using milad.shop.CustomerContext.Domain.Customers.Services;

namespace milad.shop.CustomerContext.Application.Customers
{
    public class UpdateScoreCommandHandler : ICommandHandler<UpdateScoreCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateScoreCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(UpdateScoreCommand command)
        {
            var customer = customerRepository.GetCustomer(command.CustomerId);
            customer.UpdateScore(command.Score);
        }
    }
}
