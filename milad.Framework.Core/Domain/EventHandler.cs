using System;

namespace milad.Framework.Core.Domain
{
    public class EventHandler
    {

        public EventHandler(Action<object> handlingAction)
        {
            this.Action = handlingAction;
        }

        public Action<object> Action { get; }
    }
}
