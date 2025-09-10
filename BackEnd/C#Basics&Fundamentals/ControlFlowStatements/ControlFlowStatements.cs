namespace C_Basics_Fundamentals.ControlFlowStatements
{
    public class ControlFlowStatements
    {

            private readonly static int num = 10;

            public static void ControlFlowStatementsEx()
            {
            

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
            int l = 0;
            do
            {
                Console.WriteLine(l);
                l++;
            } while(l < 2);

            // foreach loop
            Console.WriteLine("Foreach loop:");
            int[] arr = { 1, 2, 3 };
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            //Nested ForLoop
            Console.WriteLine("Nested Foreach loop:");
            for(int n = 1; n <= 3; n++)
            {
                for(int k = 1; k <= 3; k++)
                {
                    Console.WriteLine($"n = {n}, k = {k}");
                }
            }
        }
    }
}
