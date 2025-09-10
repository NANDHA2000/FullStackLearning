/*
 
👉 Class:
      ** A class is a blueprint or template for creating objects.
      ** It defines properties (fields) and behaviors (methods) that the object will have.
      ** A class does not occupy memory by itself — memory is allocated when an object is created.

 */

namespace CSharp.OOP.OOP
{
    public class Class
    {
        // Define a Class
        public class Car
        {
            // Properties (Fields)
            public string? Brand;
            public string? Model;
            public int Year;

            // Method (Behavior)
            public void DisplayInfo()
            {
                Console.WriteLine($"Car Brand: {Brand}, Model: {Model}, Year: {Year}");
            }
        }

    }
}
