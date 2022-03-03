using milad.Framework.Core.Application;

namespace milad.Framework.Application
{
    public class LogCommandHandler<TCommand> : ICommandHandler<TCommand> 
        where TCommand : Command 
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public LogCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }
        
        public void Execute(TCommand command)
        {
            commandHandler.Execute(command);

            // TODO: write a log
        }
    }
}
