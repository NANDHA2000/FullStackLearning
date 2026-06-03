using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Advanced.Multithreading
{
    public class AsyncAwaitEx
    {
        public static async Task RunAsyncAwaitExample()
        {
            Task t1 = PrintNumbersAsync();
            Task t2 = PrintAlphabetsAsync();

            await Task.WhenAll(t1, t2);

            Console.WriteLine("Main Thread Finished (Async/Await)");
        }

        private static async Task PrintNumbersAsync()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                await Task.Delay(500);
            }
        }

        private static async Task PrintAlphabetsAsync()
        {
            for(char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Alphabet: {c}");
                await Task.Delay(700);
            }
        }
    }
}
