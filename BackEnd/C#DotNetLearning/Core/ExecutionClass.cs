using CSharpLearning.RunFile;

namespace CSharpLearning.Core
{
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

        public static async void RunWeb()
        {
            await RunCSharpWeb.Run();
        }
    }
}
