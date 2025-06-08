using CSharpLearning.Loops;
using CSharpLearning.RunFile;
using CSharp.CommonUtils.Models;
using CSharp.Intermediate.LinQ;
using C_Basics_Fundamentals.ProblemStatementProgram;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {

            RunCSharpOOP.RunOops();
            RunCSharpOOP.RunSolidPrinciple();

            
            RunCSharpBasics.RunAccessModifiers();
            RunCSharpBasics.RunBasicOOP();
            RunCSharpBasics.RunControlFlowStatements();
            RunCSharpBasics.RunExceptionHandling();
            RunCSharpBasics.RunLogicalProgram();
            RunCSharpBasics.RunMethods();
            RunCSharpBasics.RunOperators();
            RunCSharpBasics.RunParameterPassingMechanisms();
            RunCSharpBasics.RunVariablesAndDataTypes();
            


            RunCSharpIntermediate.RunGenericCollections();
            RunCSharpIntermediate.RunNonGenericCollections();
            RunCSharpIntermediate.RunIEnumerableVsIQueryable();
            RunCSharpIntermediate.RunDelegatesAndEvents();
            RunCSharpIntermediate.RunExtensionMethod();
            RunCSharpIntermediate.RunSelectOperator();
            RunCSharpIntermediate.RunSelectOperator();

            RunCSharpCoding.RunLogicalProgram();






            //MatrixTransversal.DirectionalPatternMatchInGrid();

/*            var result = MatrixTransversal.DirectionalPatternMatchInGrid();

            Console.WriteLine("\nFinal Pattern Matches:");
            foreach(var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }*/

        }

    }
}