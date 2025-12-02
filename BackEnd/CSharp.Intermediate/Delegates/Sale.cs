namespace CSharp.Intermediate.Delegates
{
    public class Sale
    {
        public Customer Customer { get; set; }
        public int Discount { get; set; }

        public Sale(Customer customer)
        {
            this.Customer = customer;
        }

        public string YearEndSale()
        {
            this.Discount = 15;
            string message = string.Empty;

            // 1️⃣ Single Preference
            if (Customer.AlertPreferenceSingle != null)
            {
                if (Customer.AlertPreferenceSingle == "SMS")
                    message = Alerts.SendSMS(Customer.CustomerName!, Customer.PhoneNumber!, Discount);

                if (Customer.AlertPreferenceSingle == "Email")
                    message = Alerts.SendEmail(Customer.CustomerName!, Customer.EmailId!, Discount);

                if (Customer.AlertPreferenceSingle == "WhatsApp")
                    message = Alerts.SendWhatsApp(Customer.CustomerName!, Customer.PhoneNumber!, Discount);
            }

            // 2️⃣ Multi Preference
            else if (Customer.AlertPreferenceMulti != null)
            {
                foreach (var item in Customer.AlertPreferenceMulti)
                {
                    if (item == "SMS")
                        message += Alerts.SendSMS(Customer.CustomerName!, Customer.PhoneNumber!, Discount);

                    if (item == "Email")
                        message += Alerts.SendEmail(Customer.CustomerName!, Customer.EmailId!, Discount);

                    if (item == "WhatsApp")
                        message += Alerts.SendWhatsApp(Customer.CustomerName!, Customer.PhoneNumber!, Discount);
                }
            }

            // 3️⃣ Singlecast Delegate Preference

            else if (Customer.AlertPreferences != null)
            {
                foreach (AlertDelegate handler in Customer.AlertPreferences.GetInvocationList())
                {
                    if (handler.Method.Name == nameof(Alerts.SendEmail))
                        message += handler(Customer.CustomerName!, Customer.EmailId!, Discount);
                    else
                        message += handler(Customer.CustomerName!, Customer.PhoneNumber!, Discount);
                }
            }

            // 3️⃣ Multicast Delegate Preference
            else if (Customer.AlertPreferences != null)
            {
                foreach (AlertDelegate handler in Customer.AlertPreferences.GetInvocationList())
                {
                    if (handler.Method.Name == nameof(Alerts.SendEmail))
                        message += handler(Customer.CustomerName!, Customer.EmailId!, Discount);
                    else
                        message += handler(Customer.CustomerName!, Customer.PhoneNumber!, Discount);
                }
            }

            return message;
        }
    }
}
