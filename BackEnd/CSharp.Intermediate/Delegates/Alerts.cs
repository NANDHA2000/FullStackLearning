namespace CSharp.Intermediate.Delegates
{
        public delegate string AlertDelegate(string customerName, string mediaType, int discount);

        public class Alerts
        {
            public static string SendSMS(string customerName, string phoneNumber, int discount)
            {
                string message = "SMS Sent to " + phoneNumber + "\nDear " + customerName +
                           ", Avail " + discount +
                           "% discount on all purchased items.\n";
                return message;
            }

            public static string SendEmail(string customerName, string email, int discount)
            {
                string message = "Email Sent to " + email + "\nDear " + customerName +
                           ", Avail " + discount +
                           "% discount on all purchased items.\n";
                return message;
            }

            public static string SendWhatsApp(string customerName, string phoneNumber, int discount)
            {
                string message = "WhatsApp SMS Sent to " + phoneNumber + "\nDear " + customerName +
                           ", Avail " + discount +
                           "% discount on all purchased items.\n";
                return message;
            }
        }
}

