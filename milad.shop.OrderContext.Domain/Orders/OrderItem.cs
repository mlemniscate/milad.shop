using milad.Framework.Domain;
using System;

namespace milad.shop.OrderContext.Domain.Orders
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(Guid productId, int quantity, decimal price)
        {
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public Guid ProductId { get; private set; } 

        public int Quantity { get; private set; }

        public decimal Price { get; private set; }
    }
}
