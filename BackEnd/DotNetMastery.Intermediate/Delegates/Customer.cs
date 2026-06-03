namespace DotNetMastery.Intermediate.Delegates
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? EmailId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AlertPreferenceSingle { get; set; } // Single Preference (Without Delegates)
        public string[]? AlertPreferenceMulti { get; set; } // Multi Preferences (Without Delegates)
        public AlertDelegate AlertPreferences { get; set; } // With Delegates

        public Customer()
        {
        }
        public Customer(string customerName, string address, string emailId,
            string phoneNumber, AlertDelegate alertPreferences) : base()
        {
            this.CustomerName = customerName;
            this.Address = address;
            this.EmailId = emailId;
            this.PhoneNumber = phoneNumber;
            this.AlertPreferences = AlertPreferences!;
        }
    }
}
