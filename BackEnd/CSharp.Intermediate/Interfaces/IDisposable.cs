namespace CSharp.Intermediate.Interfaces
{
    public class IDisposable
    {

        public static void IDisposableDemo()
        {
            using(var writer = new StreamWriter("test.txt"))
            {
                writer.WriteLine("Hello IDisposable");
            } // File closed automatically
        }
    }
}
