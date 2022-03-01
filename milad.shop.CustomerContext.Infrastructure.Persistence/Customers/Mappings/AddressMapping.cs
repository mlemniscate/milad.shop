using milad.Framework.Persistence;
using milad.shop.CustomerContext.Domain.Customers;
using System.Data;

namespace milad.shop.CustomerContext.Infrastructure.Persistence.Customers.Mappings
{
    public class AddressMapping : BaseEntityMapping<Address> 
    {
        public AddressMapping()
        {
            Property(a => a.CustomerId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString())
                .IsRequired();

            Property(a => a.AddressLine)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(500)
                .IsRequired();

            Property(a => a.PostalCode)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(10)
                .IsRequired();

            Property(a => a.AddressLine)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(500)
                .IsRequired();

            Property(a => a.CityId)
                .HasColumnType(SqlDbType.Int.ToString())
                .IsRequired();


        }
    }
}
