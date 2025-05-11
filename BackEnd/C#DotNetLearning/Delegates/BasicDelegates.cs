using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DotNetLearning.Delegates
{
    public class BasicDelegates
    {
        // 1️⃣ Declare a delegate
        public delegate void PrintMessage(string message);


        // 2️⃣ Create a method that matches the delegate signature
        public static void ShowMessage(string msg)
        {
            Console.WriteLine($"Message: {msg}");
        }
    }
}
