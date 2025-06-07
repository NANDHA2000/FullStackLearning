using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNetInterviewPreparation.Coding
{
    public class Factorial
    {

        public int factorial(int n)
        {
            // Base case: factorial of 0 or 1 is 1
            if(n == 0 || n == 1)
            {
                return 1;
            }

            // Recursive case: n * factorial of (n-1)
            return n * factorial(n - 1);
        }
    }
}
