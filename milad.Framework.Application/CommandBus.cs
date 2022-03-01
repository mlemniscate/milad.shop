using milad.Framework.Core.Application;
using milad.Framework.Core.DependencyInjection;

namespace milad.Framework.Application
{
    public class CommandBus : ICommandBus
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : Command
        {
            var commandHanlder = ServiceLocator.Current.Resolve<ICommandHandler<TCommand>>();
            commandHanlder.Execute(command);
        }
    }
}
