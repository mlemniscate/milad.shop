using milad.shop.ReadModel.Queries.Contracts.Customers.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.ReadModel.Queries.Contracts.Customers
{
    public interface ICustomerQueryFacade
    {
        IList<CustomerDto> GetCustomers(string keyword);
    }
}
