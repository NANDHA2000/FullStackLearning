using CSharp.CommonUtils.Models;
using System.Text.Json;

namespace CSharp.Advanced.SerializationDeserialization
{
    public static class Deserialization
    {

        public static void Deserialize(string jsonString)
        {
            // Deserialize (JSON string → object)
            Person? deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);

            Console.WriteLine($"Deserialized From JSON string to Object: Id: {deserializedPerson?.ID}, Name: {deserializedPerson?.Name}, Age: {deserializedPerson?.Age}");
        }
    }
}
