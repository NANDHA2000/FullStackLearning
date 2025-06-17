using CSharp.Advanced.Multithreading;
using CSharp.Intermediate.LinQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Advanced.Generics.Generics;

namespace CSharpLearning.RunFile
{
    public class RunCSharp
    {

        public static void RunMultithreadingTaskParallelism()
        {
            AsyncAwaitEx.RunAsyncAwaitExample();
            TaskEx.RunTaskExample();
            ThreadEx.RunThreadExample();
        }

        public static void RunGenerics()
        {
            // Generic class
            Box<double> doubleBox = new Box<double> { Value = 99.9 };
            doubleBox.ShowType();

            // Generic method
            string a = "Apple", b = "Banana";
            GenericUtils.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            // Generic constraint
            Calculator<int> calc = new Calculator<int>();
            Console.WriteLine($"Add: {calc.Add(10, 20)}");
        }
    }
}
