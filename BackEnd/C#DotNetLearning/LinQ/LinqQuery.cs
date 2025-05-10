using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DotNetLearning.LinQ
{
    public class LinqQuery
    {

        public static void LinQ() 
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
