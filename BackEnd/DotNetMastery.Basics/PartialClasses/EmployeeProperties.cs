using System;

namespace DotNetMastery.Basics.PartialClasses
{
    /* -----------------------------------------------------------------------------
    C# Partial Classes Reference (Part 1: Properties/Data)
    -----------------------------------------------------------------------------
    🧩 Partial Class Mechanics:
       - The 'partial' keyword allows a single class definition to span multiple files.
       - All parts must share the exact same namespace and access modifier (e.g., public).
       - At compile time, the compiler merges all separate parts into a single unified type.
       - This part handles the structural state (properties and fields) of the Employee entity.
    -----------------------------------------------------------------------------
    */

    public partial class Employee
    {
        #region Encapsulated Properties

        /// <summary>
        /// Gets or sets the unique identifier for the employee.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the employee's full name. Supports nullability.
        /// </summary>
        public string? Name { get; set; }

        #endregion
    }
}