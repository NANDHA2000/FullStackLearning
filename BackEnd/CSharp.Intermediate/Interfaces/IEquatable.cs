using CSharp.CommonUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
