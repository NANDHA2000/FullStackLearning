using System;
using System.Threading;

namespace CSharp.Advanced.MultithreadingAndTaskParallelism
{
    public class ThreadEx
    {
        public static void RunThreadExample()
        {
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintAlphabets);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main Thread Finished");
        }

        private static void PrintNumbers()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500); // simulate work
            }
        }

        private static void PrintAlphabets()
        {
            for(char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Alphabet: {c}");
                Thread.Sleep(700); // simulate work
            }
        }
    }
}
