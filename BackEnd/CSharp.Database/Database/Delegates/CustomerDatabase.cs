using CSharp.CommonUtils.Models;

namespace CSharp.Database.Database.Delegates
{
    public class CustomerDatabase
    {
        public static List<Customer> GetCustomerDatabase()
        {
            return new List<Customer>
            {
            new Customer{ CustomerName = "Alice Smith",Address = "123 Oak St, Anytown",EmailId= "alice.s@example.com",PhoneNumber= "555-1234",AlertPreferences = "Email" },
            new Customer{ CustomerName = "Bob Johnson",Address = "45 Pine Ln, Otherville",EmailId= "bob.j@example.com",PhoneNumber= "555-5678",AlertPreferenceMulti = new[] { "Email", "SMS" } },
            new Customer{ CustomerName = "Charlie Brown",Address = "789 Cedar Ave, Somewhere",EmailId= "c.brown@example.com",PhoneNumber= "555-9012",AlertPreferences = "SMS" },
            };
        }

    }
}
