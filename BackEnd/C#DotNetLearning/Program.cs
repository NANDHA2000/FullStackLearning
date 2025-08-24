using CSharpLearning.RunFile;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {


            //RunCSharpOOP
                 RunCSharpOOP.RunOops();


            //RunCSharpExpertPatterns
                RunCSharpExpertPatterns.RunSolidPrinciple();


            //RunCSharpBasics
                RunCSharpBasics.RunAccessModifiers();
                RunCSharpBasics.RunBasicOOP();
                RunCSharpBasics.RunControlFlowStatements();
                RunCSharpBasics.RunExceptionHandling();
                RunCSharpBasics.RunLogicalProgram();
                RunCSharpBasics.RunMethods();
                RunCSharpBasics.RunOperators();
                RunCSharpBasics.RunParameterPassingMechanisms();
                RunCSharpBasics.RunVariablesAndDataTypes();
                RunCSharpBasics.RunValueTypeAndReferenceType();
                RunCSharpBasics.RunCasting();


            //RunCSharpIntermediate
                RunCSharpIntermediate.RunGenericCollections();
                RunCSharpIntermediate.RunNonGenericCollections();
                RunCSharpIntermediate.RunIEnumerableVsIQueryable();
                RunCSharpIntermediate.RunDelegatesAndEvents();
                RunCSharpIntermediate.RunExtensionMethod();
                RunCSharpIntermediate.RunSelectOperator();
                RunCSharpIntermediate.RunSelectOperator();
                RunCSharpIntermediate.RunIEnumerableVsIQueryable();

                       

            //RunCSharpCoding
                RunCSharpCoding.RunLogicalProgram();


            //RunCSharpRealWorld
                RunCSharpRealWorld.RunFindCurrentAgeOfStudent();


            /*MatrixTransversal.DirectionalPatternMatchInGrid();

           var result = MatrixTransversal.DirectionalPatternMatchInGrid();

                        Console.WriteLine("\nFinal Pattern Matches:");
                        foreach(var kvp in result)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }*/

            /*
                        AnonymousMethods anonymousMethods = new AnonymousMethods();

                        AnonymousMethods.PointToMethod operations = anonymousMethods.Add;

                        operations(1,2);
                        anonymousMethods.Add(1, 2);


                        OriginalClass originalClass = new OriginalClass();
                        originalClass.Id = 1;

                        PartialClass1 partialClass1 = new PartialClass1();
                        partialClass1.*/

        }

    }
}