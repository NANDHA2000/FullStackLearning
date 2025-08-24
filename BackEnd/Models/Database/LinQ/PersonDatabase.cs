using CSharp.CommonUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CommonUtils.Database.LinQ
{
    public class PersonDatabase
    {
        public static List<Person> GetPersonDatabase() 
        {
            List<Person> person = new List<Person>
            {
                new Person { ID = 1, Name = "John Smith", Phone = "1234567890" },
                new Person { ID = 2, Name = "Michael", Phone = "2345678901" },
                new Person { ID = 3, Name = "Akhil", Phone = "3456789012" },
                new Person { ID = 4, Name = "Rohit", Phone = "4567890123" },
                new Person { ID = 5, Name = "", Phone = "4567890123" }
            };

            return person;
        }
    }
}
