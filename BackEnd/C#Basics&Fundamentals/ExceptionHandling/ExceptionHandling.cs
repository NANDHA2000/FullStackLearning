using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.ExceptionHandling
{
    public class ExceptionHandling
    {
        public static void ExceptionHandlingEx()
        {
            try
            {
                int a = 10, b = 0;
                int result = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZero: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally always runs.");
            }
        }
    }
}
