#region Sealed Def and Use Case
/*

sealed in C#?

** A sealed class is a class that cannot be inherited.

** A sealed method is a method in a base class that prevents further overriding in derived classes.



Why do we need sealed?

The purpose of sealed is to restrict inheritance and control class hierarchies. It gives the developer control 
over where polymorphism stops.

✅ Key reasons:

1.Security / Integrity

Prevents altering critical logic through inheritance.
Example: If you create a BankAccount class, you may want to prevent someone from inheriting and overriding deposit/withdraw logic.

2.Performance Optimization

Virtual methods need runtime lookup (via a vtable).

Sealing a class or method allows the compiler/JIT to make optimizations because it knows no further overrides exist.

3.Design Intent (Final behavior)

Some classes are "complete" and should not be extended.
Example: System.String in .NET is sealed because it’s designed to be immutable and safe. Allowing inheritance could break that.

4.Maintainability

Prevents misuse of your class by others who might extend it in unexpected ways.


*/
#endregion


namespace CSharp.OOP.ClassMembers
{
    public class Sealed
    {

        #region Sealed Class
        // Sealed class example

        public sealed class BankAccount
        {
            public void Deposit(decimal amount)
            {
                Console.WriteLine($"Deposited {amount}");
            }
        }

        // ❌ This will throw a compile-time error
        // public class SavingsAccount : BankAccount { } 
        #endregion

        #region Sealed Method
        // Sealed method example

        public class Parent
        {
            public virtual void Work()
            {
                Console.WriteLine("Parent is working...");
            }
        }

        public class Child : Parent
        {
            public sealed override void Work()
            {
                Console.WriteLine("Child has finalized work behavior.");
            }
        }

        public class GrandChild : Child
        {
            // ❌ Error: Cannot override sealed method 'Work'
            // public override void Work() { }
        } 
        #endregion

    }
}
