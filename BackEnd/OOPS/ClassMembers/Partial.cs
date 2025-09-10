/*
 
** A partial class allows a single class to be split across multiple files or in the same file.

** Useful in large projects where auto-generated code (e.g., by Visual Studio) can be separated from developer-written code.

** All parts must use the partial keyword and have the same namespace and class name.
 
 */


namespace CSharp.OOP.ClassMembers
{
    public static class Partial
    {

        public partial class Person
        {
            public string? FirstName { get; set; }
        }

        public partial class Person
        {
            public string? LastName { get; set; }
            public void PrintFullName()
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
        }
    }
}
