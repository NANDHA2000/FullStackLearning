namespace C_Basics_Fundamentals
{
    public class VariablesAndDataTypes
    {
        public static void VariablesAndDataType()
        {
            int age = 30;
            float height = 5.9f;
            double pi = 3.14159;
            char grade = 'A';
            bool isActive = true;
            string name = "John Doe";

            var city = "Bangalore"; // implicitly typed
            dynamic salary = 50000; // can change type at runtime
            salary = "Fifty Thousand";

            const double gravity = 9.8; // constant
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Pi: {pi}, Grade: {grade}, Active: {isActive}");
            Console.WriteLine($"City: {city}, Salary: {salary}, Gravity: {gravity}");
        }

        // Instance variable (field)
        public string instanceName = "InstanceName";

        // Static variable
        public static int staticCounter = 0;

        // Constant field
        public const double Gravity = 9.8;

        // Readonly field
        public readonly DateTime createdAt;

        // Static readonly field
        public static readonly string appVersion = "1.0." + DateTime.Now.Second;

        // Auto-property
        public int Age { get; set; }

        // Constructor
        public VariablesAndDataTypes()
        {
            createdAt = DateTime.Now; // readonly assigned at runtime
            staticCounter++; // increment static field
        }

        // Method with parameter variable
        public void PrintMessage(string message)
        {
            Console.WriteLine($"Parameter Variable (message): {message}");
        }
    }
}
