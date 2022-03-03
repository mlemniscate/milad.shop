using milad.Framework.Core.Application;
using milad.Framework.Core.DependencyInjection;

namespace milad.Framework.Application
{
    public class CommandBus : ICommandBus
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : Command
        {
            var commandHandler = ServiceLocator.Current.Resolve<ICommandHandler<TCommand>>();
            var transactionalDecorator = new TransactionalCommandHandler<TCommand>(commandHandler);
            var logDecorator = new LogCommandHandler<TCommand>(transactionalDecorator);
            var exceptionControllingDecorator = new ExceptionControllerCommandHandler<TCommand>(logDecorator);    
            exceptionControllingDecorator.Execute(command);
        }
    }
}
