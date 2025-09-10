namespace CSharp.Coding.Sequence
{
    public class NumberSeries
    {

        public void RunNumberSeries() 
        {
            int i = 1;   // starting number
            int terms = 10;  // how many numbers you want to generate

            Console.WriteLine("Series:");
            for(int count = 0; count < terms; count++)
            {
                Console.Write(i + " ");
                i = i * 2 + 1;  // formula
            }
        }
    }
}
