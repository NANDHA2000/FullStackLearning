/*

 abstraction is the process of hiding certain details and showing only essential information to the user.

    **** Abstract class: is a restricted class that cannot be used to create objects
    **** Only we can give definition to abstract class implementation we have to give to derived class.

*/

#region Def
/* 1️⃣ Abstract Class
Definition:
** An abstract class is a class that cannot be instantiated.

** It can have abstract methods (without body) and normal methods (with body).

** It is used to provide a base definition for derived classes.


2️⃣ Interface
Definition:
** An interface is a contract. It contains only declarations (no implementation).

** Classes or structs implement interfaces and provide the actual behavior.


| Feature                 | Abstract Class                               | Interface                                |
| ----------------------- | -------------------------------------------- | ---------------------------------------- |
| Methods                 | Can have both abstract & normal              | Only declarations (no code)              |
| Variables               | Can have fields/variables                    | No variables (only properties/constants) |
| Multiple inheritance    | Not supported                                | Supported (multiple interfaces)          |
| Constructor             | Can have constructor                         | Cannot have constructor                  |
| Accessibility Modifiers | Can have modifiers (public, protected, etc.) | All members are public by default        | 
#endregion

*/
#endregion

namespace CSharp.OOP.OOPs
{

    
    public static class Abstraction
    {

        #region Abstract
        // Abstraction in C# (Using Abstract Class)

        public abstract class Animal
        {
            // Abstract method (no implementation here)
            public abstract void MakeSound();

            // Regular method (with implementation)
            public void Sleep()
            {
                Console.WriteLine("I am sleeping.");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }
        }
        #endregion


        #region Interface
        // Abstraction in C# (Using Interface)


        public interface IAnimal
        {
            void MakeSound();
            void Sleep();
        }

        public class DogInterface : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }
            public void Sleep()
            {
                Console.WriteLine("Dog is sleeping.");
            }
        }

        public class CatInterface : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }
            public void Sleep()
            {
                Console.WriteLine("Cat is sleeping.");
            }
        } 
        #endregion
    }

}
