﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Customers.Services
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
    }
}
