/*
 
🔹 What is a Nested Class?

A nested class is a class that is declared inside another class.

    ** Think of it like: "a class within a class".
    
    ** It is useful when a class is only related to its outer class.
    
    ** The nested class can access private members of the outer class.
 
*/

namespace CSharp.OOP.ClassMembers
{
    public class Nested
    {

        public class OuterClass
        {
            private string message = "Hello from Outer Class";

            // Nested class
            public class InnerClass
            {
                public void ShowInner()
                {
                    Console.WriteLine("Hello from Inner Class");
                }
            }

            // Nested class accessing outer class
            public class Helper
            {
                private OuterClass outer;
                public Helper(OuterClass o)
                {
                    outer = o;
                }

                public void ShowOuterMessage()
                {
                    Console.WriteLine($"Outer says: {outer.message}");
                }
            }
        }
    }
}
