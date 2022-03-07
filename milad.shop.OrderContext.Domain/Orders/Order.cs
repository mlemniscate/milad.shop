using milad.Framework.Core.Domain;
using milad.Framework.Domain;
using milad.shop.OrderContext.Domain.Contracts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.OrderContext.Domain.Orders
{
    public class Order : BaseEntity, IAggregateRoot<Order>
    {
        private const int K = 1000;

        public Order(int number, IEnumerable<OrderItem> cart)
        {
            Number = number;
            SetCart(cart);
            var score = CalculateScore();
            EventBus.Publish(new OrderCreatedEvent(Id, score));
        }


        public int Number { get; private set; }

        public decimal Tax { get; private set; }

        public decimal ShippingCost { get; private set; }

        public decimal TotalAmount { get; private set; }

        public ICollection<OrderItem> Cart { get; private set; }

        public IEnumerable<Expression<Func<Order, dynamic>>> GetAggregateExpressions()
        {
            yield return o => o.Cart;
        }

        private int CalculateScore()
        {
            if(TotalAmount < 100 * K)
            {
                return 1;
            }

            if(TotalAmount < 200 * K)
            {
                return 2;
            }
            if(TotalAmount < 500 * K)
            {
                return 5;
            }
            return 10;
        }

        private void AddOrderItem(Guid productId, int quantity, decimal price)
        {
            Cart.Add(new OrderItem(productId, quantity, price));
            CalculateTotalAmount();
        }

        private void SetCart(IEnumerable<OrderItem> cart)
        {
            if(!cart.Any())
            {
                // throw ex
            }

            foreach (var item in cart)
            {
                AddOrderItem(item.ProductId, item.Quantity, item.Price);
            }
        }

        private void CalculateTotalAmount()
        {
            var subtotal = Cart.Sum(item => item.Price * item.Quantity);
            ShippingCost = subtotal < 100000 ? 0 : 10000;
            Tax = (ShippingCost + subtotal) * (decimal)0.13;
            TotalAmount = subtotal + Tax + ShippingCost;
        }

    }
}
