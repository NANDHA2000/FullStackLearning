using CSharp.CommonUtils.Enum;
using CSharpLearning.Interfaces;
using CSharpLearning.Services;

namespace CSharpLearning
{
    // Entry point
    class Program
    {

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Select module to run:");
            foreach(var module in Enum.GetValues<ExecutionEnum>())
            {
                Console.WriteLine($"{(int)module} - {module}");
            }

            Console.Write("Enter module number: ");
            var input = Console.ReadLine();

            if(int.TryParse(input, out int moduleInt) &&
                Enum.IsDefined(typeof(ExecutionEnum), moduleInt))
            {
                var module = (ExecutionEnum)moduleInt;
                IExecutionService executor = new ExecutionService();
                await executor.RunAsync(module);
            }
            else
            {
                Console.WriteLine("Invalid module selected!");
            }


            Console.WriteLine("Execution completed. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
