#region Def and Use Case - Prototype Design Pattern
/*

✅ Prototype Design Pattern – Definition

The Prototype Design Pattern is a creational design pattern that allows you to create new objects by copying (cloning) 
existing objects (prototypes) instead of creating them from scratch.

----------------------------------*------------------------------------

✅ Purpose of Prototype Design Pattern

🔧 Avoid costly object creation if creating a new object is expensive (e.g., complex initialization).

⚡ Improve performance by copying existing objects.

🧱 Useful when you want to create many similar objects with slight differences.

💡 Avoid complex constructors and configuration by cloning a pre-configured prototype.

----------------------------------*------------------------------------

✅ How It Works (Simplified Explanation)

You have a prototype object that serves as a template.

Instead of creating a new object from scratch, you clone the prototype.

The clone can be modified if needed without affecting the prototype.


----------------------------------*------------------------------------


*/
#endregion



using CSharp.CommonUtils.Models;

namespace CSharp.ExpertPatterns.DesignPattern.Creational
{

    public interface IPrototype
    {
        IPrototype ShallowClone();
        IPrototype DeepClone();
    }


    public class Prototype: IPrototype
    {

        public Person? PersonData { get; set; }

        public IPrototype ShallowClone()
        {
            // Simple shallow copy
            return (IPrototype)this.MemberwiseClone();
        }

        public IPrototype DeepClone()
        {
            return new Prototype
            {
                PersonData = new Person
                {
                    Name = this.PersonData!.Name,
                    Age = this.PersonData.Age,
                    Address = new Address
                    {
                        Street = this.PersonData.Address!.Street,
                        City = this.PersonData.Address.City
                    }
                }
            };
        }

        public override string ToString()
        {
            return PersonData!.ToString()!;
        }
    }

    
}
