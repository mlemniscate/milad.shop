using System.Linq;
using milad.shop.ReadModel.Context;
using milad.shop.ReadModel.Queries.Contracts.Customers;
using milad.shop.ReadModel.Queries.Contracts.Customers.DataContracts;
using System.Collections.Generic;

namespace milad.shop.ReadModel.Queries.Facade.Customers
{
    public class CustomerQueryFacade : ICustomerQueryFacade
    {
        public IList<CustomerDto> GetCustomers(string keyword)
        {
            using (var context = new MiladEntities())
            {
                return (from customer in context.Customers
                        where customer.FirstName.Contains(keyword) ||
                        customer.LastName.Contains(keyword) ||
                        customer.Email.Contains(keyword) 
                        let hasAddress = customer.Addresses.Any()
                        select new CustomerDto
                        {
                            Id = customer.Id,
                            FirstName = customer.FirstName,
                            LastName = customer.LastName,
                            Email = customer.Email,
                            HasAddress = hasAddress
                        }).ToList();
            }
        }
    }
}
