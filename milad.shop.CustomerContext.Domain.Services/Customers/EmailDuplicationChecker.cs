using milad.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Services.Customers
{
    public class EmailDuplicationChecker : IEmailDuplicationChecker
    {
        private readonly ICustomerRepository customerRepository;

        public EmailDuplicationChecker(
            ICustomerRepository customerRepository
            )
        {
            this.customerRepository = customerRepository;
        }

        public bool IsDuplicated(string email)
        {
            return customerRepository.Contains(c => c.Email == email);
        }
    }
}
