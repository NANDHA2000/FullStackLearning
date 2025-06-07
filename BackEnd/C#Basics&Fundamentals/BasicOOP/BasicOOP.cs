using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.BasicOOP
{
    public class BasicOOP
    {
        public static void BasicOOPEx()
        {
            Person p = new Person("John", 25);
            p.Display();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
    }
}
