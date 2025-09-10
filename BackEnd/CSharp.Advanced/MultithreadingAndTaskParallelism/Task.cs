using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Advanced.MultithreadingAndTaskParallelism
{
    public class TaskEx
    {
        public static void RunTaskExample()
        {
            Task task1 = Task.Run(() => PrintNumbers());
            Task task2 = Task.Run(() => PrintAlphabets());

            Task.WaitAll(task1, task2);

            Console.WriteLine("Main Thread Finished (Tasks)");
        }

        private static void PrintNumbers()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                Task.Delay(500).Wait(); // simulate work
            }
        }

        private static void PrintAlphabets()
        {
            for(char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Alphabet: {c}");
                Task.Delay(700).Wait(); // simulate work
            }
        }
    }
}
