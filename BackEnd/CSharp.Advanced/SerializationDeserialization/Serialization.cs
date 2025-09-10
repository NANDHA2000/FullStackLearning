using CSharp.CommonUtils.Models;
using System.Text.Json;

namespace CSharp.Advanced.SerializationDeserialization
{
    public static class Serialization
    {

        public static void Serialize(object obj)
        {
            // Create an object
            var person = new Person
            {
                ID = 1,
                Name = "Nandhakumar A",
                Age = 25
            };

            // Serialize (object → JSON string)
            Console.WriteLine("---- Serialize Demo ----\n");

            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine($"Serialized From Object to JSON string : {jsonString} \n");



            Console.WriteLine("----De-Serialize Demo ----\n");
            Deserialization.Deserialize(jsonString); // Calling Deserialization method

        }
    }
}
