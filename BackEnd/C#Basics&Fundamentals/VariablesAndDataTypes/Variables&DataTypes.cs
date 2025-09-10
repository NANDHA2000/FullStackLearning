/*
 
Local Variable
    ** A variable declared inside a method. It exists only during the execution of that method and cannot be accessed outside of it.

Instance Variable (Field)
    ** A variable declared in a class without the static keyword. Each object (instance) of the class has its own copy of the variable.

Static Variable (Field)
    ** A variable declared in a class with the static keyword. It belongs to the class itself and is shared across all instances of the class.

Constant (const) Field
    ** A field whose value is known at compile time and cannot be changed. Constants are implicitly static and cannot be modified after declaration.

Readonly Field
    ** A field whose value can be assigned only during declaration or inside the constructor. It can have different values for different instances of the class but cannot be modified after the object is constructed.

Static Readonly Field
    ** A field that is shared across all instances of the class and can be assigned only during declaration or inside a static constructor. It cannot be modified afterward.

Auto-Property
    ** A property with automatic backing fields created by the compiler. It provides a simple way to declare properties without manually defining the field.

Parameter Variable
    ** A variable that is declared in a method's parameter list. It receives its value from the calling code when the method is invoked.

var Keyword
    ** A keyword that allows the compiler to infer the type of the variable from the expression on the right-hand side at compile time. Once inferred, the type is fixed.

dynamic Keyword
    ** A variable whose type is determined at runtime and can change during execution. The compiler does not check type safety for dynamic variables.
 

 */




namespace C_Basics_Fundamentals
{
    public class VariablesAndDataTypes
    {
        // ===== FIELDS =====

        // Instance variable (each object has its own copy)
        public string instanceName = "InstanceName";

        // Static variable (shared by all objects of the class)
        public static int staticCounter = 0;

        // Constant field (fixed value, known at compile time)
        public const double Gravity = 9.8;

        // Readonly field (assigned once at runtime in constructor)
        public readonly DateTime createdAt;

        // Static readonly field (shared by all objects, assigned at declaration or static constructor)
        public static readonly string appVersion = "1.0." + DateTime.Now.Second;

        // Auto-property (with automatic backing field)
        public int Age { get; set; }


        // ===== CONSTRUCTOR =====
        public VariablesAndDataTypes()
        {
            // Assign readonly field
            createdAt = DateTime.Now;

            // Increment staticCounter when new object is created
            staticCounter++;
        }


        // ===== STATIC METHOD DEMONSTRATING LOCAL VARIABLES =====
        public static void VariablesAndDataType()
        {
            // Local variables (inside method)
            int age = 30;
            float height = 5.9f;
            double pi = 3.14159;
            char grade = 'A';
            bool isActive = true;
            string name = "John Doe";

            var city = "Bangalore"; // var = implicitly typed variable

            dynamic salary = 50000; // dynamic = type can change at runtime
            salary = "Fifty Thousand";

            const double gravity = 9.8; // constant local variable (different from class-level Gravity field)

            // Display local variables
            Console.WriteLine("---- Local Variables ----");
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Pi: {pi}, Grade: {grade}, Active: {isActive}");
            Console.WriteLine($"City: {city}, Salary: {salary}, Gravity: {gravity}");
        }


        // ===== INSTANCE METHOD WITH PARAMETER VARIABLE =====
        public void PrintMessage(string message)
        {
            Console.WriteLine($"Parameter Variable (message): {message}");
        }
    }
}
