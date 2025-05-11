using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPreCode.SolidPrinciple
{

    /*      
            Dependency Inversion Principle (DIP)

            "High-level modules should not depend on low-level modules. Both should depend on abstractions 
            (e.g., interfaces)." 

    */


    public class DependencyInversionPrinciple
    {

        #region DIP Code
        // Without DIP:

        public class EmailServiceDIP1
        {
            public void SendEmailDIP(string message)
            {
                Console.WriteLine("Sending Email: " + message);
            }
        }

        public class NotificationDIP1
        {
            private EmailServiceDIP1 _emailService;

            public NotificationDIP1()
            {
                _emailService = new EmailServiceDIP1();  // tightly coupled to EmailService
            }

            public void SendEmailDIP(string message)
            {
                _emailService.SendEmailDIP(message);    // directly depends on concrete implementation
            }
        }

        // With DIP:

        public interface IMessageService
        {
            void SendMessage(string message);
        }

        public class EmailServiceDIP2 : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine("Sending Email: " + message);
            }
        }

        public class NotificationDIP2
        {
            private readonly IMessageService _messageService;

            // Dependency is injected via constructor, depending on abstraction
            public NotificationDIP2(IMessageService messageService)
            {
                _messageService = messageService;
            }

            public void Send(string message)
            {
                _messageService.SendMessage(message);  // depends on the abstraction, not a concrete class
            }
        }

        #endregion
    }
}
