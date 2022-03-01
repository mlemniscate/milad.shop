using milad.shop.CustomerContext.Domain.Customers;
using milad.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Infrastructure.Persistence.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Contains(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
