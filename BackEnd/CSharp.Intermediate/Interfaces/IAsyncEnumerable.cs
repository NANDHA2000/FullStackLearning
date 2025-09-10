namespace CSharp.Intermediate.Interfaces
{
    public class IAsyncEnumerable
    {
        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for(int i = 1; i <= 3; i++)
            {
                await Task.Delay(500);
                yield return i;
            }
        }


        public static async Task Run()
        {
            await foreach(var number in GetNumbersAsync())
                Console.WriteLine(number);
        }
    }
}
