using milad.Framework.Core.Application;
using System;

namespace milad.shop.CustomerContext.Application.Contracts.Customers
{
    public class UpdateScoreCommand : Command
    {
        public UpdateScoreCommand(Guid customerId, int score)
        {
            CustomerId = customerId;
            Score = score;
        }

        public Guid CustomerId { get; private set; }

        public int Score { get; private set; }
    }
}
