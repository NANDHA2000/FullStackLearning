using C_DotNetLearning.Collections;
using C_DotNetLearning.LinQ;
using C_DotNetLearning.Models;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinqQuery.LinQ();
            IEnumerableVsIQueryable.IEnumerable();
            IEnumerableVsIQueryable.IQueryable();

            RunExtensionMethod();
            RunSelectOperator();

            RunGenericCollections();
            RunNonGenericCollections();

        }


        public static void RunExtensionMethod() 
        {
            string sentence = "Welcome to Dotnet Tutorials";

            int number = 123456;

            (int wordCount,int charCount) = sentence.GetWordCount();
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
                                              EmployeeId = emp.ID ,
                                              FullName = emp.FirstName +""+ emp.LastName,
                                              AnnualSalary = emp.Salary *12
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


        public static void RunGenericCollections() 
        {
            //List
            var list = Generic.List();
            foreach(var item in list)
            {
                Console.WriteLine(item);
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
    }
}