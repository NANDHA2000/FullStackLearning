using CSharp.CommonUtils.Models;
using CSharp.ExpertPatterns.DesignPattern.Creational;
using CSharp.ExpertPatterns.SolidPrinciple;

namespace CSharpLearning.RunFile
{
    public class RunCSharpExpertPatterns
    {

        public static void RunSolidPrinciple()
        {

            // Solid Principle

            #region SRP Main Code
            Console.WriteLine("\n---- SRP ----");

            // Without SRP:
            var orderProcessor1 = new SingleResponsibilityPrinciple.OrderProcessorWOSRP();
            orderProcessor1.ProcessOrder("Order123");

            // With SRP:
            SingleResponsibilityPrinciple.IEmailService emailService = new SingleResponsibilityPrinciple.EmailService();
            var orderProcessor2 = new SingleResponsibilityPrinciple.OrderProcessorWSRP(emailService);
            orderProcessor2.ProcessOrder("Order123");

            Console.WriteLine("\n---- **** ----");
            #endregion

            #region OCP Main Code

            Console.WriteLine("\n---- OCP ----");

            // Without OCP:
            var rectangle1 = new OpenClosedPrinciple.Rectangle1 { Width = 5, Height = 4 };
            var circle1 = new OpenClosedPrinciple.Circle1 { Radius = 3 };

            var calculator1 = new OpenClosedPrinciple.AreaCalculator1();
            Console.WriteLine($"Rectangle Area: {calculator1.CalculateArea(rectangle1)}");
            Console.WriteLine($"Circle Area: {calculator1.CalculateArea(circle1)}");


            // With OCP:
            OpenClosedPrinciple.IShape rectangle2 = new OpenClosedPrinciple.Rectangle2 { Width = 5, Height = 4 };
            OpenClosedPrinciple.IShape circle2 = new OpenClosedPrinciple.Circle2 { Radius = 3 };

            var calculator2 = new OpenClosedPrinciple.AreaCalculator2();
            Console.WriteLine($"Rectangle Area: {calculator2.CalculateArea(rectangle2)}");
            Console.WriteLine($"Circle Area: {calculator2.CalculateArea(circle2)}");

            Console.WriteLine("\n---- **** ----");

            #endregion

            #region LSP Main Code
            Console.WriteLine("\n---- LSP ----");
            // Without LSP:
            LiskovSubstitutionPrinciple.Bird1 myBird1 = new LiskovSubstitutionPrinciple.Bird1();
            myBird1.Fly();  // Works fine

            LiskovSubstitutionPrinciple.Bird1 myOstrich1 = new LiskovSubstitutionPrinciple.Ostrich1();
            // This violates LSP because Ostrich cannot fly, causing an exception
            myOstrich1.Fly(); // Without OCP:


            // With LSP:
            LiskovSubstitutionPrinciple.Bird2 myFlyingBird = new LiskovSubstitutionPrinciple.FlyingBird2();
            myFlyingBird.Move();  // Works fine, bird flies

            LiskovSubstitutionPrinciple.Bird2 myOstrich2 = new LiskovSubstitutionPrinciple.Ostrich2();
            myOstrich2.Move();  // Works fine, ostrich runs

            Console.WriteLine("\n---- **** ----");
            #endregion

            #region ISP Main Code
            Console.WriteLine("\n---- ISP ----");
            // Without ISP:
            InterfaceSegregationPrinciple.IMachine printer1 = new InterfaceSegregationPrinciple.Printer1();
            printer1.Print("Document");

            // With ISP:
            InterfaceSegregationPrinciple.IPrinter printer2 = new InterfaceSegregationPrinciple.Printer2();
            printer2.Print("Document");

            InterfaceSegregationPrinciple.IScanner scanner = new InterfaceSegregationPrinciple.Scanner();
            scanner.Scan("Document");

            InterfaceSegregationPrinciple.MultiFunctionMachine multiMachine = new InterfaceSegregationPrinciple.MultiFunctionMachine();
            multiMachine.Print("Document");
            multiMachine.Scan("Document");
            multiMachine.Fax("Document");
            Console.WriteLine("\n---- **** ----");
            #endregion

            #region DIP Main Code
            Console.WriteLine("\n---- ISP ----");
            // Without DIP:
            DependencyInversionPrinciple.NotificationDIP1 notification1 = new DependencyInversionPrinciple.NotificationDIP1();
            notification1.SendEmailDIP("Hello, DIP!");

            // With DIP:
            DependencyInversionPrinciple.IMessageService emailService2 = new DependencyInversionPrinciple.EmailServiceDIP2(); // Can inject different services here
            DependencyInversionPrinciple.NotificationDIP2 notification2 = new DependencyInversionPrinciple.NotificationDIP2(emailService2);
            emailService2.SendMessage("Hello,I Coming from Email");
            notification2.Send("Hello,I Coming from Notify");
            Console.WriteLine("\n---- **** ----");
            #endregion
        }


        public static void RunDesignPattern()
        {

            #region Prototype Pattern
            Console.WriteLine("\n---- Prototype Pattern ----");

            // Prototype Pattern
            var original = new Prototype
            {
                PersonData = new Person
                {
                    Name = "AJ",
                    Age = 30,
                    Address = new Address { Street = "North Street", City = "Chennai" }
                }
            };

            Console.WriteLine("\nOriginal: " + original);

            var shallowClone = original.ShallowClone() as Prototype;

            shallowClone!.PersonData!.Name = "SK"; // Modify the clone's name
            shallowClone.PersonData.Age = 28; // Modify the clone's age
            shallowClone.PersonData.Address = new Address { Street = "South Street", City = "Tenkasi" }; // Modify the clone's address street

            Console.WriteLine("\nShallow Clone: " + shallowClone);

            var deepClone = original.DeepClone() as Prototype;

            deepClone!.PersonData!.Name = "NK"; // Modify the clone's name
            deepClone.PersonData.Age = 25; // Modify the clone's age
            deepClone.PersonData.Address!.Street = "East Street"; // Modify the clone's address
            deepClone.PersonData.Address.City = "Nagercoil"; // Modify the clone's address city

            Console.WriteLine("\nDeep Clone: " + deepClone);


            Console.WriteLine("\n---- **** ----"); 
            #endregion


        }
    }
}
