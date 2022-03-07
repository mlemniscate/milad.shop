using milad.Framework.Application;
using milad.shop.OrderContext.Application.Contracts;
using milad.shop.OrderContext.Domain.Orders;
using milad.shop.OrderContext.Domain.Orders.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Application
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
    {
        private readonly IOrderRepository orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void Execute(CreateOrderCommand command)
        {
            var orderNumber = orderRepository.GenerateOrderNumber();
            var cart = command.Cart.Select(c => new OrderItem(c.ProductId, c.Quantity, c.Price));
            var order = new Order(orderNumber, cart);

            orderRepository.Create(order);
        }
    }
}
