using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOP.SolidPrinciple
{

    /*Single Responsibility Principle(SRP) --

   " Each class and modules in a program should focus on a single task " */

    public class SingleResponsibilityPrinciple
    {
        #region SRP Code


        // Without SRP:

        public class OrderProcessorWOSRP
        {
            public void ProcessOrder(string order)
            {
                // Process the order
                Console.WriteLine($"Processing order: {order}");

                // Send email notification (violating SRP)
                Console.WriteLine("Sending email confirmation...");

                SendEmail(order);
            }

            private void SendEmail(string order)
            {
                Console.WriteLine($"Email sent for order: {order}");
            }
        }

        // With SRP:

        public class OrderProcessorWSRP
        {
            private readonly IEmailService _emailService;

            public OrderProcessorWSRP(IEmailService emailService)
            {
                _emailService = emailService;
            }

            public void ProcessOrder(string order)
            {
                // Process the order
                Console.WriteLine($"Processing order: {order}");

                // Delegate email sending to a separate service
                _emailService.SendEmail(order);
            }
        }

        public interface IEmailService
        {
            void SendEmail(string order);
        }

        public class EmailService : IEmailService
        {
            public void SendEmail(string order)
            {
                Console.WriteLine($"Email sent for order: {order}");
            }
        }



        #endregion
    }
}
