using DotNetMastery.CommonUtils.Models;
using Microsoft.Data.SqlClient;
using System.Text;

namespace DotNetMastery.RealWorld.RestAPIs
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        // 1. READ ALL (GET)
        public async Task<List<Product>> GetAllAsync()
        {
            var products = new List<Product>();
            const string sql = "SELECT Id, Name, Category, Price, Stock, IsActive, CreatedAt FROM Products;";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            await conn.OpenAsync();

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                products.Add(MapToProduct(reader));
            }
            return products;
        }

        // 2. READ BY ID (GET/{id})
        public async Task<Product?> GetByIdAsync(int id)
        {
            const string sql = "SELECT Id, Name, Category, Price, Stock, IsActive, CreatedAt FROM Products WHERE Id = @Id;";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            await conn.OpenAsync();

            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync() ? MapToProduct(reader) : null;
        }

        // 3. CREATE (POST)
        public async Task<int> CreateAsync(Product product)
        {
            const string sql = @"
            INSERT INTO Products (Name, Category, Price, Stock, IsActive)
            OUTPUT INSERTED.Id
            VALUES (@Name, @Category, @Price, @Stock, @IsActive);";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);

            await conn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        // 4. FULL UPDATE (PUT)
        public async Task<bool> UpdateAsync(int id, Product product)
        {
            const string sql = @"
            UPDATE Products
            SET Name = @Name,
                Category = @Category,
                Price = @Price,
                Stock = @Stock,
                IsActive = @IsActive
            WHERE Id = @Id;";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);

            await conn.OpenAsync();
            int rowsAffected = await cmd.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }

        // 5. PARTIAL UPDATE (PATCH)
        public async Task<bool> PatchAsync(int id, ProductPatchDto patchDto)
        {
            const string sql = @"
            UPDATE Products
            SET Price = COALESCE(@Price, Price),
                Stock = COALESCE(@Stock, Stock),
                IsActive = COALESCE(@IsActive, IsActive)
            WHERE Id = @Id;";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Price", (object?)patchDto.Price ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Stock", (object?)patchDto.Stock ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@IsActive", (object?)patchDto.IsActive ?? DBNull.Value);

            await conn.OpenAsync();
            int rowsAffected = await cmd.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }

        // 6. DELETE (DELETE)
        public async Task<bool> DeleteAsync(int id)
        {
            const string sql = "DELETE FROM Products WHERE Id = @Id;";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            await conn.OpenAsync();
            int rowsAffected = await cmd.ExecuteNonQueryAsync();

            if (rowsAffected > 0)
            {
                // 2. Reset the IDENTITY seed to the current maximum ID in the table
                // This ensures the next inserted item takes the exact next sequential number
                const string resetIdentitySql = @"
            DECLARE @MaxId INT;
            SELECT @MaxId = ISNULL(MAX(Id), 0) FROM Products;
            DBCC CHECKIDENT ('Products', RESEED, @MaxId);";

                await using var resetCmd = new SqlCommand(resetIdentitySql, conn);
                await resetCmd.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        // 7. COMPLEX SEARCH (HTTP QUERY VERB)
        public async Task<List<Product>> ExecuteQueryAsync(ProductQueryRequest filter)
        {
            var products = new List<Product>();
            const string sql = @"
            SELECT Id, Name, Category, Price, Stock, IsActive, CreatedAt
            FROM Products
            WHERE (@Category IS NULL OR Category = @Category)
              AND (@MinPrice IS NULL OR Price >= @MinPrice)
              AND (@MaxPrice IS NULL OR Price <= @MaxPrice)
              AND (@OnlyInStock IS NULL OR (@OnlyInStock = 1 AND Stock > 0))
              AND (@SearchKeyword IS NULL OR Name LIKE '%' + @SearchKeyword + '%');";

            await using var conn = GetConnection();
            await using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Category", (object?)filter.Category ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MinPrice", (object?)filter.MinPrice ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaxPrice", (object?)filter.MaxPrice ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@OnlyInStock", (object?)filter.OnlyInStock ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SearchKeyword", (object?)filter.SearchKeyword ?? DBNull.Value);

            await conn.OpenAsync();
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                products.Add(MapToProduct(reader));
            }
            return products;
        }

        private static Product MapToProduct(SqlDataReader reader)
        {
            return new Product
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Category = reader.GetString(reader.GetOrdinal("Category")),
                Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
            };
        }
    }
}
