using milad.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Customers.Services
{
    public interface IEmailDuplicationChecker : IDomainService
    {
        bool IsDuplicated(string email);
    }
}
