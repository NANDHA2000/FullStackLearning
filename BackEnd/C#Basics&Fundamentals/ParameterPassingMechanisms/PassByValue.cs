/*
 
Pass by Value: The method can't change the original value.

*/

namespace CSharpLearning.ParameterPassingMechanisms
{
    public class PassByValue
    {

        public static void Default(int x)
        {
            x = x + 10;
            Console.WriteLine($"Sum of X for default: {x}");
        }
    }
}
