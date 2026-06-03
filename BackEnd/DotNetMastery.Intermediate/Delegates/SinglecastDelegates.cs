namespace DotNetMastery.Intermediate.Delegates
{
    public class SinglecastDelegate
    {
        public static void RunSinglecastDelegate()
        {
            string preferences = "Email";

            Customer customer = new Customer()
            {
                CustomerName = "Marcus",
                Address = "Santa Cruz",
                PhoneNumber = "9878677656",
                EmailId = "marcus01@gmail.com",
                /*                AlertPreferenceSingle = preferences,
                                AlertPreferenceMulti = multiPreferences,
                                AlertPreferences = alert*/
            };

            // 1️ TEST SINGLE PREFERENCE
            Console.WriteLine("---- SINGLE PREFERENCE ----");
            customer.AlertPreferenceSingle = preferences;
            customer.AlertPreferenceMulti = null;
            customer.AlertPreferences = null;

            Console.WriteLine(new Sale(customer).YearEndSale());

            // 2 TEST DELEGATE (SINGLECAST)
            Console.WriteLine("---- DELEGATE SINGLECAST ----");
            AlertDelegate alertDelegate = Alerts.SendSMS;
            string message = alertDelegate("Aurelius", "9807865432", 15);
            Console.WriteLine(message);

            //(or)

            AlertDelegate alert = new AlertDelegate(Alerts.SendSMS);
            Customer customer1 = new Customer()
            {
                CustomerName = "Marcus",
                Address = "Santa Cruz",
                PhoneNumber = "9878677656",
                EmailId = "marcus01@gmail.com",
                AlertPreferences = alert
            };
            Console.WriteLine(message);
        }
    }
}
