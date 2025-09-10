using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 👉 Object:
      ** An object is an instance of a class.
      ** It has its own state (data) and can perform actions via methods.
 */

namespace CSharp.OOP.OOP
{
    public class Object : Class
    {
        public void Car()
        {
            // Create object of Car class
            Car myCar = new Car();

            // Set object properties
            myCar.Brand = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;

            // Call method
            myCar.DisplayInfo();

            Console.ReadLine();
        }
    }
}
