﻿using System;
using System.Collections.Generic;

namespace milad.Framework.Core.Domain
{
    internal class EventSubscriptionItem
    {
        public Type EventType { get; set; }

        public IList<EventHandler> Handlers { get; set;}

    }
}
