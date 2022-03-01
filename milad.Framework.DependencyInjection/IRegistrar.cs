using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.DependencyInjection
{
    public interface IRegistrar 
    {
        void Register(WindsorContainer container);
    }
}
