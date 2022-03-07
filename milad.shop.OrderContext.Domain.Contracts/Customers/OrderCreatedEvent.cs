using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Domain.Contracts.Customers
{
    public class OrderCreatedEvent
    {
        public OrderCreatedEvent(Guid orderId, int customerScore)
        {
            OrderId = orderId;
            CustomerScore = customerScore;
        }

        public Guid OrderId { get; private set; }

        public int CustomerScore { get; private set; }
         
    }
}
