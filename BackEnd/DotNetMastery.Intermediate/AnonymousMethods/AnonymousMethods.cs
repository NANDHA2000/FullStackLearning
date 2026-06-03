using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMastery.Intermediate.AnonymousMethods
{
    public class AnonymousMethods
    {
        public delegate int PointToMethod(int a, int b);

        public int Add(int a, int b) 
        {
           return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
