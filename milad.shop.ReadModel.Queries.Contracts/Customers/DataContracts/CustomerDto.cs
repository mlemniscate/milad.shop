﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.ReadModel.Queries.Contracts.Customers.DataContracts
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool HasAddress { get; set; }

    }
}
