using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalLibrary
{
    public interface IClonable<T>
    {
        public T Clone();
    }

    public class Account : IClonable<Account?>
    {
        public string? Name { get; set; }

        public int? Age { get; set; }
        public Address? Address { get; set; }

        public Account? Clone() {
            Account? account = base.MemberwiseClone() as Account;
            account.Address = Address?.Clone();

            return account;
        }
    }

    public class Address : IClonable<Address?>
    {
        public string Country { get; set; }
        public string City { get; set; }

        public Address? Clone() => base.MemberwiseClone() as Address;
    }
}
