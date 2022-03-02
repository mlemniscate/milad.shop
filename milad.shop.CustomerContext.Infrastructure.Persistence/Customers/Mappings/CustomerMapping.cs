using milad.Framework.Persistence;
using milad.shop.CustomerContext.Domain.Customers;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace milad.shop.CustomerContext.Infrastructure.Persistence.Customers.Mappings
{
    public class CustomerMapping : BaseEntityMapping<Customer>
    {
        public CustomerMapping()
        {
            Property(c => c.FirstName)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.LastName)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnType(SqlDbType.Char.ToString())
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Password)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .IsMaxLength()
                .IsRequired();

            HasMany(c => c.Addresses)
                .WithRequired()
                .HasForeignKey(a => a.CustomerId)
                .WillCascadeOnDelete(true);

        }
    }
}
