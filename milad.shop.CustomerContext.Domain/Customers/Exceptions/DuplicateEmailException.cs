using milad.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Customers.Exceptions
{
    public class DuplicateEmailException : DomainException
    {
        public override string Message => Resources.ExceptionResources.DuplcateEmailException;
    }
}
