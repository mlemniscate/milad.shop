using Castle.Windsor;
using milad.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.DependencyInjection
{
    public class DiContainer : IDiContainer
    {
        private readonly WindsorContainer container;

        public DiContainer(WindsorContainer container)
        {
            this.container = container;
        }
        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return container.ResolveAll<T>();
        }
    }
}
