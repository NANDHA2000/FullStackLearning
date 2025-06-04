/*
 
🔁 ref (Reference Parameter)

✅ Definition:

     * Allows a method to read and modify the value of a variable passed to it.

     * The variable must be initialized before it is passed to the method.

💡 Use Case:

       Use when you want a method to change the caller's variable and it already has an initial value.

✅ Syntax: void MethodName(ref int parameter)


-----------------*------------------------

🆙 out (Output Parameter)

✅ Definition:

       *  Allows a method to return multiple values by modifying the variable passed.

       *  The variable does not need to be initialized before being passed.

       *  The method must assign a value to the out parameter before it returns.

💡 Use Case:

       Use when you want the method to output a value, especially multiple return values.

✅ Syntax: void MethodName(out int parameter)


 */

namespace C_DotNetLearning.Modifiers
{
    public class PassByReference
    {

        public static void Ref(ref int x) 
        {
            x = x + 10;
            Console.WriteLine($"Sum of X for ref: {x}");
        }


        public static void Out(out int x)
        {
            x = 0;
            x = x + 10;
            Console.WriteLine($"Sum of X for out: {x}");
        }
    }
}
