using C_DotNetLearning.Collections;
using C_DotNetLearning.LinQ;
using DotNetInterviewPreparation.Oops;
using IntPreCode.OOPS;
using IntPreCode.SolidPrinciple;
using Models.Models;
using static C_DotNetLearning.Delegates.BasicDelegates;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinqQuery.LinQ();
            IEnumerableVsIQueryable.IEnumerable();
            IEnumerableVsIQueryable.IQueryable();

            RunExtensionMethod();
            RunSelectOperator();

            RunGenericCollections();
            RunNonGenericCollections();

            RunOops();
            RunSolidPrinciple();

        }


        public static void RunExtensionMethod() 
        {
            string sentence = "Welcome to Dotnet Tutorials";

            int number = 123456;

            (int wordCount,int charCount) = sentence.GetWordCount();
            Console.WriteLine($"Count : {wordCount}");
            Console.ReadKey();

            int numCount = number.GetNumberCount();
            Console.WriteLine($"Count : {numCount}");
            Console.ReadKey();
        }


        public static void RunSelectOperator() 
        {

            //Using Query Syntax
            List<Employee> basicQuery = (from emp in SelectOperator.GetEmployees()
                                         select emp).ToList();
            foreach(Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();

            //Using Method Syntax
            IEnumerable<Employee> basicMethod = SelectOperator.GetEmployees().ToList();
            foreach(Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();


            //Using Query Syntax
            var selectQuery = (from emp in SelectOperator.GetEmployees()
                                          select new
                                          { 
                                              EmployeeId = emp.ID ,
                                              FullName = emp.FirstName +""+ emp.LastName,
                                              AnnualSalary = emp.Salary *12
                                          });

            foreach(var emp in selectQuery)
            {
                Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            }

            Console.ReadKey();

            //Using Method Syntax
            var selectMethod = (SelectOperator.GetEmployees().Select(emp => new 
            {
                EmployeeId = emp.ID,
                FullName = emp.FirstName + "" + emp.LastName,
                AnnualSalary = emp.Salary * 12
            }).ToList());

            foreach(var emp in selectMethod)
            {
                Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            }
            Console.ReadKey();

        }


        public static void RunGenericCollections() 
        {
            //List
            var list = Generic.List();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Dictionary
            var dictionary = Generic.Dictionary();
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //HashSet
            var hashSet = Generic.HashSet();
            foreach(var item in hashSet)
            {
                Console.WriteLine(item);
            }

            //Queue
            var queue = Generic.Queue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            //SortedDictionary
            var sortedDictionary = Generic.SortedDictionary();
            foreach(var item in sortedDictionary)
            {
                Console.WriteLine(item);
            }

            //Stack
            var stack = Generic.Stack();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }


        public static void RunNonGenericCollections()
        {
            //ArrayList
            var list = NonGeneric.ArrayList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Hashtable
            var table = NonGeneric.Hashtable();
            foreach(var item in table)
            {
                Console.WriteLine(item);
            }

            //SortedList
            var sortedList = NonGeneric.SortedList();
            foreach(var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }


        public static void RunDelegates() 
        {
            // 3️⃣ Create an instance of the delegate
            PrintMessage del = ShowMessage;

            // 4️⃣ Call the method using delegate
            del("Hello from Delegate!");

            Console.ReadLine();

        }


        static void RunOops()
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

        static void RunSolidPrinciple()
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
    
    }
}