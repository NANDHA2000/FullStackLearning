using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOP.OOP
{
    public class Interface
    {
        // Interface
        public interface IShape
        {
            void Draw();
            double CalculateArea();
        }

        // Implementing interface
        public class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public static class InterfaceDemoExample
        {
            public static void Run()
            {
                Circle circle = new Circle(5);
                circle.Draw();
                Console.WriteLine($"Circle Area = {circle.CalculateArea()}");
            }
        }
    }
}
