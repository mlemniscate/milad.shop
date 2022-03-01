using milad.Framework.Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Facade
{
    public class BaseCommandFacade
    {
        public BaseCommandFacade(ICommandBus commandBus)
        {
            CommandBus = commandBus;
        }

        protected ICommandBus CommandBus { get; }


    }
}
