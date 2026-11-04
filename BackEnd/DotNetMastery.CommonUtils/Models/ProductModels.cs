namespace DotNetMastery.CommonUtils.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
    }

    // Used for HTTP PATCH (partial update)
    public class ProductPatchDto
    {
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public bool? IsActive { get; set; }
    }

    // Used for the HTTP QUERY verb (complex filtering via request body)
    public class ProductQueryRequest
    {
        public string? Category { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool? OnlyInStock { get; set; }
        public string? SearchKeyword { get; set; }
    }
}
