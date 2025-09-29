/*

✅ Factory Method Design Pattern – Definition

The Factory Method Design Pattern is a creational design pattern that provides an interface for creating objects but allows subclasses(or a factory class) to decide which class to instantiate.

👉 In simple words: It delegates the responsibility of object creation to a factory method instead of using new directly in client code.

----------------------------------*------------------------------------

✅ Purpose of Factory Method Design Pattern

⚡ Encapsulate object creation → Clients don’t need to know which concrete class is being created.

🔧 Centralize creation logic → All new object creation happens in one place (factory).

🧱 Promote loose coupling → Client depends only on abstraction (interface/abstract class), not concrete classes.

💡 Easier maintenance and scalability → Add new product types with minimal code changes (mostly in factory).

----------------------------------*------------------------------------

✅ How It Works (Simplified Explanation)

Define a common interface/abstract class (e.g., IVehicle).

Create concrete classes (Car, Bike) implementing that interface.

Create a factory method (GetVehicle) that returns the correct object based on input.

The client just calls the factory method, without using new directly.

*/

namespace CSharp.ExpertPatterns.DesignPattern.Creational
{
    public class FactoryMethod
    {

        public static class VehicleFactory
        {
            public static IVehicle GetVehicle(string vehicleType)
            {
                if(vehicleType.ToLower() == "car")
                    return new Car();
                else if(vehicleType.ToLower() == "bike")
                    return new Bike();
                else
                    throw new ArgumentException("❌ Invalid vehicle type");
            }
        }


        public interface IVehicle
        {
            void Drive();
        }


        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("🚗 Driving a Car...");
            }
        }

        public class Bike : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("🏍️ Riding a Bike...");
            }
        }

    }
}
