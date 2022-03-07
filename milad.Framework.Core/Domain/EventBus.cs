using System;
using System.Collections.Generic;
using System.Linq;

namespace milad.Framework.Core.Domain
{
    public class EventBus : IEventBus
    {
        private IList<EventSubscriptionItem> subscriptionList;

        public EventBus()
        {
            subscriptionList = new List<EventSubscriptionItem>();
        }

        public void Publish<TEvent>(TEvent domainEvent)
        {
            var existingEvent = subscriptionList.SingleOrDefault(item => item.EventType == typeof(TEvent));
            if(existingEvent != null)
            {
                foreach (var handler in existingEvent.Handlers)
                {
                    handler.Action(domainEvent); 
                }
            }
        }

        public void Subscribe<TEvent>(Action<dynamic> action)
        {
            var existingEvent = subscriptionList.SingleOrDefault(item => item.EventType == typeof(TEvent));
            if (existingEvent == null)
            {
                var newSubscription = new EventSubscriptionItem
                {
                    EventType = typeof(TEvent),
                    Handlers = new List<EventHandler>{new EventHandler(action)}
                };
                subscriptionList.Add(newSubscription);
            }
            else
            {
                existingEvent.Handlers.Add(new EventHandler(action));
            }
        }
    }
}
