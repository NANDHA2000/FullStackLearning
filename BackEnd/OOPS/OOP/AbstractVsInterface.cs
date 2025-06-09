/*
 1️⃣ Abstract Class
   Definition:
      ** An abstract class is a class that cannot be instantiated.

      ** It can have abstract methods (without body) and normal methods (with body).

      ** It is used to provide a base definition for derived classes.

  
 2️⃣ Interface
   Definition:
      ** An interface is a contract. It contains only declarations (no implementation).

      ** Classes or structs implement interfaces and provide the actual behavior.


| Feature                 | Abstract Class                               | Interface                                |
| ----------------------- | -------------------------------------------- | ---------------------------------------- |
| Methods                 | Can have both abstract & normal              | Only declarations (no code)              |
| Variables               | Can have fields/variables                    | No variables (only properties/constants) |
| Multiple inheritance    | Not supported                                | Supported (multiple interfaces)          |
| Constructor             | Can have constructor                         | Cannot have constructor                  |
| Accessibility Modifiers | Can have modifiers (public, protected, etc.) | All members are public by default        |
      
      
 
 */

namespace CSharp.OOP.OOP
{
    public class AbstractVsInterface
    {
        // Abstract Class Example
        public abstract class Vehicle
        {
            public abstract void Drive();

            public void Refuel()
            {
                Console.WriteLine("Vehicle is refueling.");
            }
        }

        public class Car : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("Car is driving.");
            }
        }

        // Interface Example
        public interface IEngine
        {
            void Start();
        }

        public class Truck : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Truck engine started.");
            }
        }

        public static class AbstractVsInterfaceComparisonExample
        {
            public static void Run()
            {
                // Abstract class example
                Car car = new Car();
                car.Drive();
                car.Refuel();

                // Interface example
                Truck truck = new Truck();
                truck.Start();
            }
        }
    }
}
