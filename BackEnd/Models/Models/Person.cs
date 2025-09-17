namespace CSharp.CommonUtils.Models
{
    public class Person : PersonExtended
    {
        public int ID { get; set; }
        //public string? Name { get; set; }
        //public int Age { get; set; }
        public string? Phone { get; set; }
    }

    public class PersonExtended
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: [{Address}]";
        }
    }
}
