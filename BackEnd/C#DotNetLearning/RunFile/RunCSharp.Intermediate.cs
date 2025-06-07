using CSharp.CommonUtils.Models;
using CSharp.Intermediate.Collections;
using CSharp.Intermediate.ExtensionMethod;
using CSharp.Intermediate.LinQ;
using CSharpLearning.LogicalProgarm;
using CSharpLearning.Modifiers;
using CSharpLearning.ParameterPassingMechanisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpLearning.Delegates.BasicDelegates;

namespace CSharpLearning.RunFile
{
    public static class RunCSharpIntermediate
    {

        //LinQ

        public static void RunIEnumerableVsIQueryable()
        {
            IEnumerableVsIQueryable.IEnumerable();
            IEnumerableVsIQueryable.IQueryable();
            LinqQuery.LinQ();
        }


        public static void RunExtensionMethod()
        {
            string sentence = "Welcome to Dotnet Tutorials";

            int number = 123456;

            (int wordCount, int charCount) = sentence.GetWordCount();
            Console.WriteLine($"Count : {wordCount}");
            Console.ReadKey();

            int numCount = number.GetNumberCount();
            Console.WriteLine($"Count : {numCount}");
            Console.ReadKey();
        }


        public static void RunSelectOperator()
        {

            //Using Query Syntax
            List<Employee> basicQuery = (from emp in SelectOperator.GetEmployees()
                                         select emp).ToList();
            foreach(Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();

            //Using Method Syntax
            IEnumerable<Employee> basicMethod = SelectOperator.GetEmployees().ToList();
            foreach(Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.ReadKey();


            //Using Query Syntax
            var selectQuery = (from emp in SelectOperator.GetEmployees()
                               select new
                               {
                                   EmployeeId = emp.ID,
                                   FullName = emp.FirstName + "" + emp.LastName,
                                   AnnualSalary = emp.Salary * 12
                               });

            foreach(var emp in selectQuery)
            {
                Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            }

            Console.ReadKey();

            //Using Method Syntax
            var selectMethod = (SelectOperator.GetEmployees().Select(emp => new
            {
                EmployeeId = emp.ID,
                FullName = emp.FirstName + "" + emp.LastName,
                AnnualSalary = emp.Salary * 12
            }).ToList());

            foreach(var emp in selectMethod)
            {
                Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            }
            Console.ReadKey();

        }

        //Collections

        public static void RunGenericCollections()
        {
            //List
            var list = Generic.List();
            foreach(var item in list)
            {
                //Console.WriteLine(item);
            }

            //Dictionary
            var dictionary = Generic.Dictionary();
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //HashSet
            var hashSet = Generic.HashSet();
            foreach(var item in hashSet)
            {
                Console.WriteLine(item);
            }

            //Queue
            var queue = Generic.Queue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            //SortedDictionary
            var sortedDictionary = Generic.SortedDictionary();
            foreach(var item in sortedDictionary)
            {
                Console.WriteLine(item);
            }

            //Stack
            var stack = Generic.Stack();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }


        public static void RunNonGenericCollections()
        {
            //ArrayList
            var list = NonGeneric.ArrayList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Hashtable
            var table = NonGeneric.Hashtable();
            foreach(var item in table)
            {
                Console.WriteLine(item);
            }

            //SortedList
            var sortedList = NonGeneric.SortedList();
            foreach(var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        //Delegates & Events

        public static void RunDelegatesAndEvents()
        {
            // 3️⃣ Create an instance of the delegate
            PrintMessage del = ShowMessage;

            // 4️⃣ Call the method using delegate
            del("Hello from Delegate!");

            Console.ReadLine();

        }


        //Extension Method

        public static void RunExtensionMehod() 
        {
            string sentence = "Hello World!";
            Console.WriteLine($"Word Count: {sentence.WordCount()}");

        }

    }
}
