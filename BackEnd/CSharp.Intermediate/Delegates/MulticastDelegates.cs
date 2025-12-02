namespace CSharp.Intermediate.Delegates
{
    public class MulticastDelegate
    {
        public static void RunMulticastDelegate()
        {
            string[] multiPreferences = new string[] { "Email", "SMS" };

            AlertDelegate alert = Alerts.SendSMS;
            alert += Alerts.SendWhatsApp;
            alert += Alerts.SendEmail;

            Customer customer = new Customer()
            {
                CustomerName = "Marcus",
                Address = "Santa Cruz",
                PhoneNumber = "9878677656",
                EmailId = "marcus01@gmail.com",
                /* AlertPreferenceSingle = preferences,
                   AlertPreferenceMulti = multiPreferences,
                   AlertPreferences = alert
                */
            };

            // 1 TEST MULTI PREFERENCE
            Console.WriteLine("---- MULTI PREFERENCE ----");
            customer.AlertPreferenceSingle = null;
            customer.AlertPreferenceMulti = multiPreferences;
            customer.AlertPreferences = null;

            Console.WriteLine(new Sale(customer).YearEndSale());

            // 2 TEST DELEGATE (MULTICAST)
            Console.WriteLine("---- DELEGATE MULTICAST ----");
            customer.AlertPreferenceSingle = null;
            customer.AlertPreferenceMulti = null;
            customer.AlertPreferences = alert;

            Console.WriteLine(new Sale(customer).YearEndSale());
        }
    }
}
