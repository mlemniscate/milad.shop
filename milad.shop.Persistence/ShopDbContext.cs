using milad.Framework.Persistence;
using milad.shop.CustomerContext.Domain.Customers;
using milad.shop.CustomerContext.Infrastructure.Persistence.Customers.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.Persistence
{
    public class ShopDbContext : DbContextBase
    {
        public ShopDbContext() : base(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Milad;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        protected override List<dynamic> DetectEntityMappings()
        {
            var entityMappings = typeof(CustomerMapping).Assembly
                .GetTypes()
                .Where(t => t.GetInterface(typeof(IEntityMapping).Name) != null)
                .Select(t => Activator.CreateInstance(t))
                .Cast<dynamic>()
                .ToList();
            return entityMappings;
        }

    }
}
