using CSharp.OOP.OOP;
using CSharp.OOP.SolidPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.RunFile
{
    public static class RunCSharpOOP
    {

        public static void RunSolidPrinciple()
        {

            // Solid Principle

            #region SRP Main Code
            // Without SRP:
            var orderProcessor1 = new SingleResponsibilityPrinciple.OrderProcessorWOSRP();
            orderProcessor1.ProcessOrder("Order123");

            // With SRP:
            SingleResponsibilityPrinciple.IEmailService emailService = new SingleResponsibilityPrinciple.EmailService();
            var orderProcessor2 = new SingleResponsibilityPrinciple.OrderProcessorWSRP(emailService);
            orderProcessor2.ProcessOrder("Order123");
            #endregion

            #region OCP Main Code
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

            #endregion

            #region LSP Main Code
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
            #endregion

            #region ISP Main Code
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
            #endregion

            #region DIP Main Code
            // Without DIP:
            DependencyInversionPrinciple.NotificationDIP1 notification1 = new DependencyInversionPrinciple.NotificationDIP1();
            notification1.SendEmailDIP("Hello, DIP!");

            // With DIP:
            DependencyInversionPrinciple.IMessageService emailService2 = new DependencyInversionPrinciple.EmailServiceDIP2(); // Can inject different services here
            DependencyInversionPrinciple.NotificationDIP2 notification2 = new DependencyInversionPrinciple.NotificationDIP2(emailService2);
            emailService2.SendMessage("Hello,I Coming from Email");
            notification2.Send("Hello,I Coming from Notify");
            #endregion
        }

        public static void RunOops()
        {
            // Oops

            #region Polymorphism

            Polymorphism.MethodOverLoading methodOverLoading = new Polymorphism.MethodOverLoading();
            methodOverLoading.Addition(1, 2);
            Console.WriteLine("Addition is :" + methodOverLoading.Addition(1, 2));

            Polymorphism.MethodOverRiding.ParentClass parentClass = new Polymorphism.MethodOverRiding.ParentClass();
            parentClass.Job("IT");

            Polymorphism.MethodOverRiding.ChildClass childclass = new Polymorphism.MethodOverRiding.ChildClass();
            childclass.Job("Software Developer");

            #endregion

            #region Encapsulation

            Encapsulation.BankAccount bankAccount = new Encapsulation.BankAccount(10000);
            bankAccount.Deposit = 100;
            Console.WriteLine("The Current account balance after credited 100 is " + bankAccount.Deposit);
            #endregion

            #region Abstraction

            Abstraction.Dog dog = new Abstraction.Dog();
            dog.MakeSound();
            dog.Sleep();

            #endregion

            #region Inheritance

            Inheritance.Animal inheritance = new Inheritance.Animal();
            inheritance.Name = "Dog";
            inheritance.Sleep();
            inheritance.Eat();

            #endregion

        }
    }
}
