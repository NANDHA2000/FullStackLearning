/* 

         ------ Const vs Read-Only vs Static -------
 
📌 1️. const → compile-time constant
 
      ** Value must be assigned at the time of declaration.

      ** Value cannot change.

      ** Value is embedded in the IL code at compile time — meaning if you change the value in the future, dependent assemblies won't automatically get the new value unless recompiled.

      ** const is implicitly static → no object required.

📌 2️. readonly → runtime constant

      ** Value must be assigned either at declaration OR inside constructor.
      
      ** Value can differ for each object if assigned in constructor.
       
      ** Value can depend on runtime calculations.
     
      ** Value is not embedded in IL — changing value in code doesn’t require recompiling dependent assemblies.
      
📌 3️. static → shared across all instances

      ** Belongs to the class, not to an object.
      
      ** One copy per type, not per instance.
      
      ** Value can change (unless combined with const or readonly).
 
 */

namespace C_Basics_Fundamentals.Variables
{
    public class StaticConstReadonly
    {
        // Variable Declarations
        const int a = 10;
        readonly int b = 20;
        static int c = 30;

        public StaticConstReadonly() // Constructor
        {
            b = a;
            c = b;
            Console.WriteLine($"value of a : {a}");
            Console.WriteLine($"value of a : {b}");
            Console.WriteLine($"value of a : {c}");
        }

        // Output : a = 10,b = 10,c = 10
    }
}
