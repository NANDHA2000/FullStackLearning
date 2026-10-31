using System.Text.Json;
using System.Text.Json.Serialization;

namespace DotNetMastery.Intermediate.Serialization
{
    #region Models
    public class EmployeeRecord
    {
        [JsonPropertyName("emp_id")]
        public int Id { get; set; }

        [JsonPropertyName("full_name")]
        public string Name { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        // Will be excluded from the generated JSON payload
        [JsonIgnore]
        public decimal InternalSalary { get; set; }

        // Omits property from JSON if its value is null
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmergencyContact { get; set; }
    }
    #endregion

    public static class JsonSerialization
    {
        #region Single Object Serialization & Deserialization
        public static void DemonstrateSingleObject()
        {
            Console.WriteLine("=== 1. Single Object Serialization & Deserialization ===");

            var employee = new EmployeeRecord
            {
                Id = 101,
                Name = "Nandhakumar A",
                Department = "Engineering",
                InternalSalary = 95000m,
                EmergencyContact = null // Will be ignored due to JsonIgnoreCondition
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Formats output with clean indents
            };

            // Serialize: In-memory Object -> JSON String
            string jsonString = JsonSerializer.Serialize(employee, options);
            Console.WriteLine("Serialized JSON Payload:");
            Console.WriteLine(jsonString);

            // Deserialize: JSON String -> In-memory Object
            EmployeeRecord? deserializedEmp = JsonSerializer.Deserialize<EmployeeRecord>(jsonString);
            Console.WriteLine($"\nDeserialized Instance: Id={deserializedEmp?.Id}, Name={deserializedEmp?.Name}, Salary={deserializedEmp?.InternalSalary} (Expected 0 due to [JsonIgnore])\n");
        }
        #endregion

        #region Collection (Array / List) Serialization
        public static void DemonstrateCollectionSerialization()
        {
            Console.WriteLine("=== 2. Collection (List / Array) Serialization ===");

            var team = new List<EmployeeRecord>
            {
                new EmployeeRecord { Id = 201, Name = "Pooja V", Department = "QA", InternalSalary = 60000m, EmergencyContact = "9876543210" },
                new EmployeeRecord { Id = 202, Name = "David M", Department = "DevOps", InternalSalary = 80000m, EmergencyContact = null }
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            // Serialize Collection
            string listJson = JsonSerializer.Serialize(team, options);
            Console.WriteLine("Serialized Array JSON:");
            Console.WriteLine(listJson);

            // Deserialize Collection back to List<T>
            List<EmployeeRecord>? deserializedList = JsonSerializer.Deserialize<List<EmployeeRecord>>(listJson, options);
            Console.WriteLine($"\nDeserialized Count: {deserializedList?.Count} items reconstructed successfully.\n");
        }
        #endregion

        #region File Stream Serialization
        public static void DemonstrateStreamSerialization()
        {
            Console.WriteLine("=== 3. Stream-Based File Serialization ===");

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employee_data.json");

            var emp = new EmployeeRecord
            {
                Id = 301,
                Name = "Suresh Kumar",
                Department = "Architecture",
                InternalSalary = 120000m,
                EmergencyContact = "044-223344"
            };

            // Writing directly to file via stream (Memory efficient for large payloads)
            using (FileStream writeStream = File.Create(filePath))
            {
                JsonSerializer.Serialize(writeStream, emp, new JsonSerializerOptions { WriteIndented = true });
            }
            Console.WriteLine($"File successfully saved at: {filePath}");

            // Reading directly from file via stream
            using (FileStream readStream = File.OpenRead(filePath))
            {
                EmployeeRecord? fileData = JsonSerializer.Deserialize<EmployeeRecord>(readStream);
                Console.WriteLine($"Read from File: {fileData?.Name} [{fileData?.Department}]\n");
            }

            // Cleanup local demo file
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        #endregion
    }
}