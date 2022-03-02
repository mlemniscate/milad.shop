using milad.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Core.Persistence
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot<TAggregateRoot>
    {

    }
}
