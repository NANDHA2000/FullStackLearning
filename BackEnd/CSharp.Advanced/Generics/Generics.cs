/*
 
What are Generics?
    Generics allow you to define a class, method, interface, or delegate with a 
    placeholder for the data type, so you can work with any type without repeating 
    code.

Why Use Generics?

   ** Code reusability: Write one method/class that works for any type.

   ** Type safety: Catch type errors at compile time.

   ** Performance: No boxing/unboxing for value types (like int, bool, etc.).
 
 */

namespace CSharp.Advanced.Generics
{
    public class Generics
    {

        // Generic class
        public class Box<T>
        {
            public T? Value { get; set; }

            public void ShowType()
            {
                Console.WriteLine($"Value: {Value}, Type: {typeof(T)}\n");
            }
        }

        // Generic Method
        public class GenericUtils
        {
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

        // Generic Constraint(Restrict T)

        public class Calculator<T> where T : struct
        {
            public T Add(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;
                return da + db;
            }
        }

    }
}
