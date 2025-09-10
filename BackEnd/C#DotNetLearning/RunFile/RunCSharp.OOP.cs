using CSharp.OOP.ClassMembers;
using CSharp.OOP.OOP;
using static CSharp.OOP.ClassMembers.Nested;
using static CSharp.OOP.ClassMembers.Sealed;

namespace CSharpLearning.RunFile
{
    public static class RunCSharpOOP
    {
        public static void RunOops()
        {
            // Oops

            #region Polymorphism

            Console.WriteLine("\n---- Polymorphism Demo ----");

            Console.WriteLine("\n---- MethodOverLoading Demo ----");
            var sumOfTwoNo = Polymorphism.MethodOverLoading.Addition(1, 2);
            var sumOfThreeNo = Polymorphism.MethodOverLoading.Addition(1, 2, 3);
            Console.WriteLine("Addition of 2 Number is :" + sumOfTwoNo);
            Console.WriteLine("Addition of 3 Number is :" + sumOfThreeNo);

            Console.WriteLine("\n---- MethodOverRiding Demo ----");
            Polymorphism.MethodOverRiding.ParentClass parentClass = new Polymorphism.MethodOverRiding.ChildClass();
            parentClass.Job("IT");

            #endregion

            #region Encapsulation

            Console.WriteLine("\n---- Encapsulation Demo ----");

            Encapsulation.BankAccount bankAccount = new Encapsulation.BankAccount(10000);
            bankAccount.Deposit = 100;
            Console.WriteLine("The Current account balance after credited 100 is " + bankAccount.Deposit);

            #endregion

            #region Abstraction

            Console.WriteLine("\n---- Abstraction Demo ----");

            Console.WriteLine("\n---- Abstract Demo ----");
            Abstraction.Dog dog = new Abstraction.Dog();
            dog.MakeSound();
            dog.Sleep();

            Console.WriteLine("\n---- Interface Demo ----");
            Abstraction.IAnimal animal = new Abstraction.DogInterface();
            animal.MakeSound();
            animal.Sleep();

            #endregion

            #region Inheritance
            Console.WriteLine("\n---- Inheritance Demo ----");

            Inheritance.Child inheritance = new Inheritance.Child();
            inheritance.Name = "Ramu";
            inheritance.PlayFootball();
            //inheritance.Sleep();
            //inheritance.Eat();
            //inheritance.PlayMusic();

            #endregion

            #region MethodOverRidingVsMethodHiding

            Console.WriteLine("\n---- MethodOverRidingVsMethodHiding Demo ----");
            MethodOverRidingVsMethodHiding.BaseClassOverRiding baseClassOverRiding = new MethodOverRidingVsMethodHiding.DerivedClassOverRiding();
            baseClassOverRiding.Greetings();


            MethodOverRidingVsMethodHiding.BaseClassHiding baseClassHiding = new MethodOverRidingVsMethodHiding.DerivedClassHiding();
            baseClassHiding.Greetings();

            #endregion

            #region Class Memebers
            Console.WriteLine("\n---- Class Memebers Demo ----");
            Console.WriteLine("\n---- Sealed Class Demo ----");

            BankAccount account = new BankAccount();
            account.Deposit(500);

            Parent parent = new Parent();
            parent.Work();   // Calls Parent method

            Child child = new Child();
            child.Work();    // Calls sealed override


            Console.WriteLine("\n---- Partial Class Demo ----");
            Partial.Person person = new Partial.Person();
            person.FirstName = "Nandha";
            person.LastName = "Kumar";
            person.PrintFullName();


            Console.WriteLine("\n---- Nested Class Demo ----");

            // Using nested class directly
            OuterClass.InnerClass inner = new OuterClass.InnerClass();
            inner.ShowInner();

            // Using nested class to access outer data
            OuterClass outer = new OuterClass();
            OuterClass.Helper helper = new OuterClass.Helper(outer);
            helper.ShowOuterMessage(); 
            #endregion

        }

    }
}
