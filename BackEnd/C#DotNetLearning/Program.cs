using C_DotNetLearning.LogicalProgarm;
using C_DotNetLearning.Loops;
using C_DotNetLearning.Modifiers;
using C_DotNetLearning.ParameterPassingMechanisms;
using C_DotNetLearning.RunFile;
using CSharp.CommonUtils.Models;
using CSharp.Intermediate.Collections;
using CSharp.Intermediate.LinQ;
using static C_DotNetLearning.AccessModifiers.AccessModifiers;
using static C_DotNetLearning.Delegates.BasicDelegates;


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


            RemoveDuplicate.RemoveDupFromArray();

            DuckNumOrNot.DuckNumberOrNot();

            ForLoop.ExecForLoop();

            //RunCSharpOOP.RunOops();
            //RunCSharpOOP.RunSolidPrinciple();


            RunCSharpBasics.RunParameterPassingMechanisms();
            RunCSharpBasics.RunAccessModifiers();
            RunCSharpBasics.RunLogicalProgram();


            RunCSharpIntermediate.RunGenericCollections();
            RunCSharpIntermediate.RunNonGenericCollections();

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





        




        



        




    }
}