using milad.Framework.Persistence;
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
        private readonly DbContextBase dbContext;

        public CustomerRepository(IDbContext dbContext)
        {
            this.dbContext = (DbContextBase)dbContext;
        }

        public bool Contains(Expression<Func<Customer, bool>> predicate)
        {
            dbContext.SaveChanges();
            return true;
        }

        public void CreateCustomer(Customer customer)
        {
            dbContext.Set<Customer>().Add(customer);
        }
    }
}
