using CSharp.CommonUtils.Enum;
using CSharpLearning.RunFile;

namespace Program
{
    #region ExecutionClass
    public class ExecutionClass
    {
        public static void RunAdvanced()
        {
            RunCSharpAdvanced.RunMultithreadingTaskParallelism();
            RunCSharpAdvanced.RunGenerics();
            RunCSharpAdvanced.RunSerializationAndDeserialization();
            RunCSharpAdvanced.RunLinqConcepts();
        }

        public static void RunBasics()
        {
            RunCSharpBasics.RunAccessModifiers();
            RunCSharpBasics.RunControlFlowStatements();
            RunCSharpBasics.RunExceptionHandling();
            RunCSharpBasics.RunLogicalProgram();
            RunCSharpBasics.RunMethods();
            RunCSharpBasics.RunOperators();
            RunCSharpBasics.RunParameterPassingMechanisms();
            RunCSharpBasics.RunVariablesAndDataTypes();
            RunCSharpBasics.RunValueTypeAndReferenceType();
            RunCSharpBasics.RunCasting();
        }

        public static void RunCoding()
        {
            RunCSharpCoding.RunLogicalProgram();
        }

        public static void RunExpertPatterns()
        {
            RunCSharpExpertPatterns.RunSolidPrinciple();
            RunCSharpExpertPatterns.RunDesignPattern();
        }

        public static void RunIntermediate()
        {
            RunCSharpIntermediate.RunGenericCollections();
            RunCSharpIntermediate.RunNonGenericCollections();
            RunCSharpIntermediate.RunIEnumerableVsIQueryable();
            RunCSharpIntermediate.RunDelegatesAndEvents();
            RunCSharpIntermediate.RunExtensionMethod();
            RunCSharpIntermediate.RunLinQ();
        }

        public static void RunOOP()
        {
            RunCSharpOOP.RunOops();
        }

        public static void RunRealWorld()
        {
            RunCSharpRealWorld.RunFindCurrentAgeOfStudent();
        }

    } 
    #endregion

    class Program
    {
        public static void Main(string[] args)
        {

            int moduleToRun = 4;

            switch(moduleToRun)
            {
                case (int)ExecutionEnum.Advanced:
                    ExecutionClass.RunAdvanced();
                    break;
                case (int)ExecutionEnum.Basics:
                    ExecutionClass.RunBasics();
                    break;
                case (int)ExecutionEnum.Coding:
                    ExecutionClass.RunCoding();
                    break;
                case (int)ExecutionEnum.ExpertPatterns:
                    ExecutionClass.RunExpertPatterns();
                    break;
                case (int)ExecutionEnum.Intermediate:
                    ExecutionClass.RunIntermediate();
                    break;
                case (int)ExecutionEnum.OOP:
                    ExecutionClass.RunOOP();
                    break;
                case (int)ExecutionEnum.RealWorld:
                    ExecutionClass.RunRealWorld();
                    break;
                default:
                    Console.WriteLine("Unknown module. Please specify one of the following: " +
                        "basics, intermediate, advanced, expertpatterns, oop, coding, realworld.");
                    break;
            }

        }

    }
}