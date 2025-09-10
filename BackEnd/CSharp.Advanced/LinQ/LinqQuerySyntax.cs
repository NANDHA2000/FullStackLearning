/*
 
What are LINQ queries in C#? Give an example.

LINQ (Language Integrated Query) is a powerful feature in C# that allows you to write queries directly 
in C# code. LINQ provides a consistent model for working with data across various sources, 
such as databases, XML documents, and collections.
 
*/

namespace CSharp.Advanced.LinQ
{
    public class LinqQuerySyntax
    {

        public static void LinqQuerySyntaxEx() 
        {
            //Step1: Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };


            //Step2: Query
            //LINQ Query using Query Syntax to fetch all numbers which are > 5
            var QuerySyntax = from obj in integerList //Data Source
                              where obj > 5 //Condition
                              select obj; //Selection


            //Step3: Execution
            foreach(var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();

        }
    }
}
