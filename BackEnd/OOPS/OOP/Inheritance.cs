/*
 Inheritance is a mechanism in object-oriented programming where one class (child or derived class) 
 acquires the properties and behaviors of another class (parent or base class)

 **  if we creating instance of object for Animal class only we will access that particular class methods 
     and properties We can able access but if you create for Dog or Cat u can able to access the Animal class 
     parent class.
 
 */

namespace CSharp.OOP.OOP
{
    public class Inheritance
    {

        // Base class (Parent class)
        public class Animal
        {
            public string? Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping.");
            }
        }

        // Derived class (Child class)
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking: Woof! Woof!");
            }
        }

        // Another Derived class
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"{Name} is meowing: Meow! Meow!");
            }
        }
    }
}
