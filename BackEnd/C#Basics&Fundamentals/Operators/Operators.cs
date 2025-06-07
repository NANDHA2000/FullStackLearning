using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.Operators
{
    public class Operators
    {
        public static void OperatorsEx()
        {
            int a = 10, b = 3;

            // Arithmetic
            Console.WriteLine($"Add: {a + b}");
            Console.WriteLine($"Sub: {a - b}");
            Console.WriteLine($"Mul: {a * b}");
            Console.WriteLine($"Div: {a / b}");
            Console.WriteLine($"Mod: {a % b}");

            // Relational
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);

            // Logical
            bool x = true, y = false;
            Console.WriteLine(x && y);
            Console.WriteLine(x || y);
            Console.WriteLine(!x);

            // Bitwise
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);

            // Assignment
            a += 5;
            Console.WriteLine(a);

            // Ternary
            int max = (a > b) ? a : b;
            Console.WriteLine($"Max: {max}");
        }
    }
}
