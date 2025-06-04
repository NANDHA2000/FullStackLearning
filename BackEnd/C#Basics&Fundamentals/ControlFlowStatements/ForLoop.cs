using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DotNetLearning.Loops
{
    public class ForLoop
    {
        //Print Numbers 

        public static void ExecForLoop() 
        {
            /*for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Next Statement");

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Next Statement");

            for(int i = 2; i <= 10; i +=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Next Statement");

            string[] names = { "Ram", "Sita", "Laxman" };

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/

            Console.WriteLine("Next Statement");

            // Print numbers from 10 to 1

/*            for(int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }*/

/*            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/


            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }


        }

    }
}
