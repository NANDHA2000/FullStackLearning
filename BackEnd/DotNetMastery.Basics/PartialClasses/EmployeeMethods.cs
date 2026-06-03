using System;
using System.Xml.Linq;

namespace DotNetMastery.Basics.PartialClasses
{
    /* -----------------------------------------------------------------------------
    C# Partial Classes Reference (Part 2: Methods/Behavior)
    -----------------------------------------------------------------------------
    🧩 Partial Class Mechanics:
       - The 'partial' keyword allows a single class definition to span multiple files.
       - All parts must share the exact same namespace and access modifier (e.g., public).
       - At compile time, the compiler merges all separate parts into a single unified type.
       - This part contains the behaviors (methods) and can seamlessly access fields 
         or properties declared in other parts of this class.
    -----------------------------------------------------------------------------
    */

    public partial class Employee
    {
        #region Business Logic / Methods

        /// <summary>
        /// Demonstrates cross-file member access. 
        /// The 'Name' property is defined in the companion properties file.
        /// </summary>
        public void DisplayDetails()
        {
            // Because the compiler merges this file with Part 1, 
            // fields and properties like 'Name' are directly accessible here.
            Console.WriteLine($"Method called successfully from the partial behavior file for Employee: {Name}");
        }

        #endregion
    }
}