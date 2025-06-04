/*

 abstraction is the process of hiding certain details and showing only essential information to the user.

    **** Abstract class: is a restricted class that cannot be used to create objects
    **** Only we can give definition to abstract class implementation we have to give to derived class.
 
*/

namespace CSharp.OOP.OOP
{

    // Abstraction in C# (Using Abstract Class)
    public class Abstraction
    {

        public abstract class Animal
        {
            // Abstract method (no implementation here)
            public abstract void MakeSound();

            // Regular method (with implementation)
            public void Sleep()
            {
                Console.WriteLine("I am sleeping.");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }
        }
    }


    // Abstraction in C# (Using Interface)


    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    // Concrete class implementing the interface
    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }

}
