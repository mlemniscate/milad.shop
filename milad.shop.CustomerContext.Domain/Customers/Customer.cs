using milad.Framework.Core.Security;
using milad.Framework.Domain;
using milad.shop.CustomerContext.Domain.Customers.Exceptions;
using milad.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.shop.CustomerContext.Domain.Customers
{
    public class Customer : BaseEntity
    {
        private readonly IEmailDuplicationChecker emailDuplicationChekcer;
        private readonly IHashProvider hashProvider;

        public Customer(
            IEmailDuplicationChecker emailDuplicationChekcer,
            IHashProvider hashProvider,
            string firstName,
            string lastName,
            string email,
            string password)
        {
            SetFullName(firstName, lastName);
            SetEmail(email);
            SetPassword(password);
            this.emailDuplicationChekcer = emailDuplicationChekcer;
            this.hashProvider = hashProvider;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Address> Addresses { get; set; }

        private void SetEmail(string email)
        {
            if(string.IsNullOrEmpty(email))
            {
                // TODO: wirte exception and throw it
            }

            // TODO: write a regex for email and exception for it

            if(emailDuplicationChekcer.IsDuplicated(email))
            {
                throw new DuplicateEmailException();
            }

            Email = email;
        }

        private void SetFullName(string firstName, string lastName)
        {
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                // TODO: wirte exception and throw it
            }

            FirstName = firstName;
            LastName = lastName;
        }
        private void SetPassword(string password)
        {
            // validate 

            Password = hashProvider.Hash(password, Id.ToString());
        }


    }
}
