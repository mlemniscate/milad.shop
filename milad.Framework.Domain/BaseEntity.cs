using milad.Framework.Core.DependencyInjection;
using milad.Framework.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Domain
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        protected IEventBus EventBus => ServiceLocator.Current.Resolve<IEventBus>();

    }
}
