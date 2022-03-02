using milad.Framework.Persistence;
using milad.shop.CustomerContext.Domain.Customers;
using milad.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace milad.shop.CustomerContext.Infrastructure.Persistence.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>,ICustomerRepository
    {
        private readonly DbContextBase dbContext;

        public CustomerRepository(IDbContext dbContext) : base(dbContext)
        {
            this.dbContext = (DbContextBase)dbContext;
        }

        public bool Contains(Expression<Func<Customer, bool>> predicate)
        {
            return Set.Any(predicate); 
        }

        public void CreateCustomer(Customer customer)
        {
            Set.Add(customer);
        }

        public Customer GetCustomer(Guid customerId)
        {
            return GetById(customerId);
        }
    }
}
