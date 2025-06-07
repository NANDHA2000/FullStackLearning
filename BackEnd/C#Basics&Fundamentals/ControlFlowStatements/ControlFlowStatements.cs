using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.ControlFlowStatements
{
    public class ControlFlowStatements
    {
            public static void ControlFlowStatementsEx()
            {
            int num = 7;

            // if
            if(num > 0)
                Console.WriteLine("Positive number");

            // if-else
            if(num % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");

            // if-else-if
            if(num == 0)
                Console.WriteLine("Zero");
            else if(num > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");

            // switch
            int day = 3;
            switch(day)
            {
                case 1: Console.WriteLine("Mon"); break;
                case 2: Console.WriteLine("Tue"); break;
                case 3: Console.WriteLine("Wed"); break;
                default: Console.WriteLine("Invalid day"); break;
            }

            // for loop
            Console.WriteLine("For loop:");
            for(int i = 0; i < 5; i++)
            {
                if(i == 2) continue; // skip 2
                if(i == 4) break;    // break at 4
                Console.WriteLine(i);
            }

            // while loop
            Console.WriteLine("While loop:");
            int j = 0;
            while(j < 3)
            {
                Console.WriteLine(j);
                j++;
            }

            // do-while loop
            Console.WriteLine("Do-While loop:");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while(k < 2);

            // foreach loop
            Console.WriteLine("Foreach loop:");
            int[] arr = { 1, 2, 3 };
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
