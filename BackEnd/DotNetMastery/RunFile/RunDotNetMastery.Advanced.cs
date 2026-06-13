using CSharp.Advanced.Multithreading;
using static DotNetMastery.Advanced.Generics.Generics;

namespace DotNetMastery.RunFile
{
    public class RunDotNetMasteryAdvanced
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
