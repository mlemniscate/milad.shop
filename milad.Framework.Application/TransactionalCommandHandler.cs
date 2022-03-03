using milad.Framework.Core.Application;
using milad.Framework.Core.DependencyInjection;
using milad.Framework.Persistence;

namespace milad.Framework.Application
{
    public class TransactionalCommandHandler<TCommand> : ICommandHandler<TCommand> 
        where TCommand : Command 
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public TransactionalCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }
        public void Execute(TCommand command)
        {
            var unitOfWork = ServiceLocator.Current.Resolve<IUnitOfWork>();
            try
            {
                commandHandler.Execute(command);
                unitOfWork.Commit();
            }
            catch (System.Exception)
            {
                unitOfWork.Rollback();
                throw;
            }
        }
    }
}
