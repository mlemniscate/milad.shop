using milad.Framework.Domain;
using System;

namespace milad.shop.CustomerContext.Domain.Customers
{
    public class Address : BaseEntity
    {
        public Address(Guid customerId, int cityId, string postalCode, string addressLine)
        {
            CustomerId = customerId;
            CityId = cityId;
            SetPostalCode(postalCode);
            SetAddressLine(addressLine);
        }

        public string PostalCode { get; private set; }

        public string AddressLine { get; private set; }

        public int CityId { get; private set; }

        public Guid CustomerId { get; private set; }

        private void SetAddressLine(string addressLine)
        {
            // TODO: validate 

            AddressLine = addressLine;
        }

        private void SetPostalCode(string postalCode)
        {
            // TODO: validate

            PostalCode = postalCode;
        }
    }
}