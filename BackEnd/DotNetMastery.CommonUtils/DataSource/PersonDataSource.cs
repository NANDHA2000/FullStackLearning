using DotNetMastery.CommonUtils.Models;

namespace DotNetMastery.CommonUtils.DataSources
{
    public static class PersonDataSource
    {
        public static List<Person> GetPersonList() => new List<Person>
        {
            new Person { ID = 1, Name = "John Smith", Phone = "1234567890" },
            new Person { ID = 2, Name = "Michael", Phone = "2345678901" },
            new Person { ID = 3, Name = "Akhil", Phone = "3456789012" },
            new Person { ID = 4, Name = "Rohit", Phone = "4567890123" },
            new Person { ID = 5, Name = string.Empty, Phone = "4567890123" } // Edge case: empty name & duplicate phone
        };

        public static Person[] GetPersonArray() => GetPersonList().ToArray();

        public static Dictionary<int, Person> GetPersonDictionary() =>
            GetPersonList().ToDictionary(p => p.ID);
    }
}