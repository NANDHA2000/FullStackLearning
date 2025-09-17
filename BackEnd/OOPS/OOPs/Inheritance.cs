/*
 
 Inheritance is a mechanism in object-oriented programming where one class (child or derived class) 
 acquires the properties and behaviors of another class (parent or base class)

 **  if we creating instance of object for Animal class only we will access that particular class methods 
     and properties We can able access but if you create for Dog or Cat u can able to access the Animal class 
     parent class.


 **  -- Single inheritance → with classes (Child : Parent).
    -- Multiple inheritance → only with interfaces (Child : IFather, IMother, IOther...).


 ** Base class is used to refer as Parent class(base class) via child class(derived class)
 
 */

namespace CSharp.OOP.OOPs
{
    public class Inheritance
    {

        // Base class (Parent class)
        public class Parent
        {
            public string? Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"Parent -- {Name} is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping.");
            }
        }

        // Derived class (Child class)
        public class Child : Parent
        {
            //public new void Eat()
            //{
            //    Console.WriteLine($"Child 1 -- {Name} is eating.");
            //}

            public void PlayFootball()
            {
                Name = "Nandha";
                Eat(); // Calls Child1's Eat method
                //base.Eat(); // Calls Parent's Eat method
                Console.WriteLine($"{Name} is playing football.");
            }
        }

/*        // Another Derived class
        public class Child1 : Parent
        {
            public void PlayMusic()
            {
                Console.WriteLine($"{Name} is playing guitar.");
            }
        }*/

    }
}
