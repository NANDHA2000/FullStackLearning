/*
 
Swap two integers without using the third variable in C#
There are two ways you can use to swap two numbers without using the third variable:

1.By using * and /
2.By using + and –
 
 
 
 */

namespace CSharpLearning.LogicalProgarm
{
    public class SwapTwoValues
    {
        public static void SwapTwoNumber() 
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before Swapping number1= {num1}, number2 = {num2}");

            num1 = num1 * num2;

            num2 = num1 / num2;
            num1 = num1 / num2;

            Console.WriteLine($"After swapping number1= {num1}, number2 = {num2}");
            Console.ReadKey();

        } 


        
        public static void SwapTwoStrings() 
        {
            string name1 = "Dotnet", name2 = "Tutorials";

            Console.WriteLine($"Before SWapping name1= {name1}, name2 = {name2}");

            // Step1: append 2nd string with the 1st string 
            name1 = name1 + name2;  // 15

            //Step2: store intial string name1 in string name2 
            name2 = name1.Substring(0, name1.Length - name2.Length); // 15 - 9 = 6

            //Step3:  store initial string name2 in string name1 
            name1 = name1.Substring(name2.Length);

            Console.WriteLine($"After swapping name1= {name1}, name2 = {name2}");

            Console.ReadKey();

        }




    }
}
