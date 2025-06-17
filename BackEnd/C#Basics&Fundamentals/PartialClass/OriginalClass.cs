using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.PartialClass
{
    public class OriginalClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Method() 
        {
            Console.WriteLine("Method is calling");
        }
    }
}
