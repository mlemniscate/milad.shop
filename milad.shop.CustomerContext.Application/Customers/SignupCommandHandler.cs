using milad.Framework.Application;
using milad.Framework.Core.Security;
using milad.shop.CustomerContext.Application.Contracts.Customers;
using milad.shop.CustomerContext.Domain.Customers;
using milad.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Application.Customers
{
    public class SignupCommandHandler : ICommandHandler<SignupCommand>
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IEmailDuplicationChecker emailDuplicationChecker;
        private readonly IHashProvider hashProvider;

        public SignupCommandHandler(
            ICustomerRepository customerRepository,
            IEmailDuplicationChecker emailDuplicationChecker,
            IHashProvider hashProvider
            )
        {
            this.customerRepository = customerRepository;
            this.emailDuplicationChecker = emailDuplicationChecker;
            this.hashProvider = hashProvider;
        }
        public void Execute(SignupCommand command)
        {
            var customer = new Customer(
                emailDuplicationChecker,
                hashProvider,
                command.FirstName,
                command.LastName,
                command.Email,
                command.Password
                );

            customerRepository.CreateCustomer(customer);
        }
    }
}
