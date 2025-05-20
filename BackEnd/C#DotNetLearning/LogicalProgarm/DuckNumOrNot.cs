using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_DotNetLearning.LogicalProgarm
{
    public class DuckNumOrNot
    {
        public static void DuckNumberOrNot() 
        {
            string number = "12304";
            if(string.IsNullOrEmpty(number) || number[0] == '0') 
            {
                Console.WriteLine("Number is not a Duck Number");
                return;
            }

            // Check if there's a '0' anywhere after the first digit
            for(int i = 1; i < number.Length; i++)
            {
                if(number[i] == '0')
                {
                    Console.WriteLine("Number is Duck Number");
                    return;
                }
            }

            Console.WriteLine("Number is not a Duck Number");
        }
    }
}
