using milad.Framework.Core.Application;
using milad.shop.OrderContext.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Application.Contracts
{
    public class CreateOrderCommand : Command
    {
        public Guid CustomerId { get; set; }

        public IList<OrderItem> Cart { get; set; }
    }
}
