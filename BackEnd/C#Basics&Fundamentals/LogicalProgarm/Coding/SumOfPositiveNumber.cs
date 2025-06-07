using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding
{
    public class SumOfPositiveNumber
    {

        public void SumOfPositiveNumbers() 
        {
            int num = 168;

            int sum = 0;
            while(num > 0)
            {
                sum += num % 10; // sum = sum + num % 10 => Take the remainder is 8
                num /= 10; // num = num / 10 => 168/10 = 16 => Take the Quotient 

                // Value of number is still exist once the value is 0 loop will stop and we will get the sum.
            }
            Console.WriteLine(sum);

            // Output is 15
        }
    }
}
