using milad.Framework.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Customers.Services
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void CreateCustomer(Customer customer);

        bool Contains(Expression<Func<Customer, bool>> predicate);

        Customer GetCustomer(Guid customerId);
    }
}
