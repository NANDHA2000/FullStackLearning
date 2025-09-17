using CSharp.CommonUtils.Models;

namespace CSharp.Intermediate.Interfaces
{
    public class IEquatable
    {
        public static void IEquatableDemo()
        {
            var p1 = new Person { Name = "John" };
            var p2 = new Person { Name = "John" };

            Console.WriteLine(p1.Equals(p2)); // True
        }
    }
}
