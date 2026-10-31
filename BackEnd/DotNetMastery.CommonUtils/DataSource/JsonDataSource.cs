namespace DotNetMastery.CommonUtils.DataSources
{
    public static class JsonDataSource
    {
        // Ready-to-use JSON string for Person Deserialization
        public static string SinglePersonJson => """
        {
            "ID": 10,
            "Name": "Nandha Kumar",
            "Phone": "9876543210"
        }
        """;

        // JSON collection with case-insensitivity practice
        public static string BookListJson => """
        [
            {
                "id": 101,
                "title": "CLR via C#",
                "author": "Jeffrey Richter",
                "genre": "Programming",
                "yearPublished": 2012,
                "price": 55.00
            },
            {
                "id": 102,
                "title": "Design Patterns",
                "author": "Erich Gamma",
                "genre": "Architecture",
                "yearPublished": 1994,
                "price": 48.00
            }
        ]
        """;
    }
}