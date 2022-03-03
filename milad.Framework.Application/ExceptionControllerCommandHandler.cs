using milad.Framework.Core.Application;

namespace milad.Framework.Application
{
    public class ExceptionControllerCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : Command
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public ExceptionControllerCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public void Execute(TCommand command)
        {
            try
            {
                commandHandler.Execute(command);
            }
            catch (System.Exception)
            {
                // handle exception
            }
        }
    }
}
