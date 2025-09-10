using CSharp.Advanced.LinqConcepts;
using CSharp.Advanced.MultithreadingAndTaskParallelism;
using CSharp.Advanced.SerializationDeserialization;
using CSharp.OOP.OOP;
using System.Diagnostics;
using static CSharp.Advanced.Generics.Generics;

namespace CSharpLearning.RunFile
{
    public class RunCSharpAdvanced
    {

        public static void RunMultithreadingTaskParallelism()
        {
            _ = AsyncAwaitEx.RunAsyncAwaitExample();
            TaskEx.RunTaskExample();
            ThreadEx.RunThreadExample();
        }

        public static void RunGenerics()
        {
            Console.WriteLine("\n---- Generic class Demo ----");

            // Generic class
            Box<double> doubleBox = new Box<double> { Value = 99.9 };
            doubleBox.ShowType();

            Box<string> stringBox = new Box<string> { Value = "Nandha" };
            stringBox.ShowType();

            Console.WriteLine("\n---- Generic method Demo ----");

            // Generic method
            string a = "Apple", b = "Banana";
            GenericUtils.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}\n");

            Console.WriteLine("\n---- Generic constraint Demo ----");

            // Generic constraint
            Calculator<int> calc = new Calculator<int>();
            Console.WriteLine($"Add: {calc.Add(10, 20)} \n");

        }

        public static void RunSerializationAndDeserialization()
        {
            Console.WriteLine("\n---- Serialization And Deserialization Concepts Demo ----");
            Serialization.Serialize(new object());
        }


        public static void RunLinqConcepts()
        {
            Console.WriteLine("\n---- Linq Concepts Demo ----");

            Aggregation.AggregateOperations();
            Combining.CombineEvenWithSquares();
            Condition.CheckNumbers();
            Conversion.ConvertNumbers();
            DistinctElements.DistinctNumbers();
            Filtering.FilteringNumbers();
            Grouping.GroupNumbers();
            Join.JoinIdsWithNames();
            Ordering.SortNumbers();
            Projection.GetSquares();
            Selection.ElementSelection();


        }
    }
}
