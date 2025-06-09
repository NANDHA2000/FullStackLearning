using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.Reversing
{
    public static class ReversingNumber
    {

        public static void ReversingNumbers()
        {
            int InputNumber = 123456;

            string ReversedNumber = InputNumber.ToString();

            for(int i = ReversedNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(ReversedNumber[i]);
            }


            // Output : 654321
        }
    }
}
