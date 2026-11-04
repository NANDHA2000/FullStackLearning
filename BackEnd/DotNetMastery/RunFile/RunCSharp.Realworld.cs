using DotNetMastery.CommonUtils.Models;
using DotNetMastery.RealWorld.RestAPIs;
using DotNetMastery.RealWorld.Security;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Text;

namespace DotNetMastery.RunFile
{
    public class RunCSharpRealworld
    {
        public static void RunSecurity()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("          AUTHENTICATION & AUTHORIZATION DEMO               ");
            Console.WriteLine("============================================================\n");

            #region 1. Basic Authentication Test
            Console.WriteLine("--- 1. Basic Authentication ---");
            string basicHeader = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes("admin:secretPassword123"));
            bool isBasicValid = AuthenticationTypes.VerifyBasicAuthentication(basicHeader, "admin", "secretPassword123");
            Console.WriteLine($"Header: {basicHeader}");
            Console.WriteLine($"Is Basic Auth Valid: {isBasicValid}\n");
            #endregion

            #region 2. API Key Authentication Test
            Console.WriteLine("--- 2. API Key Authentication ---");
            string validSystemKey = "API-KEY-NET8-ABC-999";
            string clientApiKey = "API-KEY-NET8-ABC-999";
            bool isKeyValid = AuthenticationTypes.VerifyApiKey(clientApiKey, validSystemKey);
            Console.WriteLine($"Client Key: {clientApiKey}");
            Console.WriteLine($"API Key Verification Passed: {isKeyValid}\n");
            #endregion

            #region 3. JWT Token Generation & Validation
            Console.WriteLine("--- 3. JWT Token Authentication ---");
            string jwt = AuthenticationTypes.GenerateJwtToken(userId: "usr_1001", username: "Nandha", role: "Admin");
            Console.WriteLine($"Generated JWT:\n{jwt}\n");

            ClaimsPrincipal? validatedPrincipal = AuthenticationTypes.ValidateJwtToken(jwt);
            Console.WriteLine($"JWT Successfully Validated: {validatedPrincipal != null}");
            Console.WriteLine($"Identity Name: {validatedPrincipal?.Identity?.Name}\n");
            #endregion

            #region 4. Authorization Demonstrations
            Console.WriteLine("--- 4. Authorization Strategies ---");
            if (validatedPrincipal != null)
            {
                // Role-Based Check
                bool isAdmin = AuthorizationTypes.AuthorizeRole(validatedPrincipal, "Admin");
                bool isManager = AuthorizationTypes.AuthorizeRole(validatedPrincipal, "Manager");
                Console.WriteLine($"[RBAC] In 'Admin' Role: {isAdmin}");
                Console.WriteLine($"[RBAC] In 'Manager' Role: {isManager}");

                // Claim-Based Check
                bool isEngineering = AuthorizationTypes.AuthorizeClaim(validatedPrincipal, "Department", "Engineering");
                Console.WriteLine($"[Claims] Belongs to 'Engineering': {isEngineering}");

                // Policy-Based Check
                bool passedEngineeringPolicy = AuthorizationTypes.EvaluateEngineeringPolicy(validatedPrincipal);
                Console.WriteLine($"[Policy] Passed Complex Engineering Policy: {passedEngineeringPolicy}");

                // Resource-Based Check
                var myBook = new AuthorizationTypes.ResourceBook { BookId = 1, Title = "C# Mastery", OwnerUserId = "usr_1001" };
                var otherBook = new AuthorizationTypes.ResourceBook { BookId = 2, Title = "Java Basics", OwnerUserId = "usr_9999" };

                bool canEditMyBook = AuthorizationTypes.CanEditBook(validatedPrincipal, myBook);
                bool canEditOtherBook = AuthorizationTypes.CanEditBook(validatedPrincipal, otherBook);

                Console.WriteLine($"[Resource] Can Edit Owned Book: {canEditMyBook}");
                Console.WriteLine($"[Resource] Can Edit Other's Book (Allowed because Admin): {canEditOtherBook}");
            }
            #endregion

            Console.WriteLine("\n============================================================");
            Console.WriteLine("                      DEMO COMPLETED                        ");
            Console.WriteLine("============================================================");
        }

        public static async Task RunRestApiCrudAsync()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("        REST API CRUD & HTTP QUERY OPERATIONS DEMO          ");
            Console.WriteLine("============================================================\n");

            // 1. Read Connection String from appsettings.json (No hardcoding)
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found in appsettings.json.");

            // 2. Initialize DbHelper and ProductsController
            var dbHelper = new DbHelper(connectionString);
            var controller = new RestApiCrud.ProductsController(dbHelper);

            #region 1. POST - Create New Product
            Console.WriteLine("--- 1. [POST] Create New Product ---");
            var newProduct = new Product
            {
                Name = "Thunderbolt 4 NVMe Enclosure",
                Category = "Hardware",
                Price = 3499.00m,
                Stock = 20,
                IsActive = true
            };

            var postResult = await controller.Create(newProduct) as Microsoft.AspNetCore.Mvc.CreatedAtActionResult;
            var createdProduct = postResult?.Value as Product;
            int createdId = createdProduct?.Id ?? 0;
            Console.WriteLine($"Status: {postResult?.StatusCode} | Created Product: '{createdProduct?.Name}' | Assigned ID: {createdId}\n");
            #endregion

            #region 2. GET - Read All & Read By ID
            Console.WriteLine("--- 2. [GET] Read All & Read By ID ---");
            var getAllResult = await controller.GetAll() as Microsoft.AspNetCore.Mvc.OkObjectResult;
            var allProducts = getAllResult?.Value as List<Product>;
            Console.WriteLine($"Total Products in Database: {allProducts?.Count ?? 0}");

            var getByIdResult = await controller.GetById(createdId) as Microsoft.AspNetCore.Mvc.OkObjectResult;
            var singleProduct = getByIdResult?.Value as Product;
            if (singleProduct != null)
            {
                Console.WriteLine($"Fetched by ID ({createdId}): {singleProduct.Name} | Price: Rs.{singleProduct.Price} | Stock: {singleProduct.Stock}\n");
            }
            #endregion

            #region 3. PUT - Full Resource Update
            Console.WriteLine("--- 3. [PUT] Full Resource Update ---");
            var updatedProduct = new Product
            {
                Id = createdId,
                Name = "Thunderbolt 4 NVMe Pro Enclosure",
                Category = "Hardware",
                Price = 3999.00m,
                Stock = 18,
                IsActive = true
            };

            var putResult = await controller.Update(createdId, updatedProduct);
            bool isPutSuccess = putResult is Microsoft.AspNetCore.Mvc.NoContentResult;
            Console.WriteLine($"PUT Update Passed (204 NoContent): {isPutSuccess}");

            var afterPut = (await controller.GetById(createdId) as Microsoft.AspNetCore.Mvc.OkObjectResult)?.Value as Product;
            Console.WriteLine($"Updated Name: {afterPut?.Name} | Updated Price: Rs.{afterPut?.Price}\n");
            #endregion

            #region 4. PATCH - Partial Resource Update
            Console.WriteLine("--- 4. [PATCH] Partial Update (Stock & Price Only) ---");
            var patchPayload = new ProductPatchDto
            {
                Price = 3299.00m,
                Stock = 10
            };

            var patchResult = await controller.Patch(createdId, patchPayload);
            bool isPatchSuccess = patchResult is Microsoft.AspNetCore.Mvc.NoContentResult;
            Console.WriteLine($"PATCH Update Passed (204 NoContent): {isPatchSuccess}");

            var afterPatch = (await controller.GetById(createdId) as Microsoft.AspNetCore.Mvc.OkObjectResult)?.Value as Product;
            Console.WriteLine($"After PATCH -> Name (Unchanged): {afterPatch?.Name} | New Price: Rs.{afterPatch?.Price} | New Stock: {afterPatch?.Stock}\n");
            #endregion

            #region 5. QUERY - Complex Filter Search with Request Body
            Console.WriteLine("--- 5. [QUERY] Complex Search Filter (Safe Idempotent Body Query) ---");
            var queryFilter = new ProductQueryRequest
            {
                Category = "Accessories",
                MinPrice = 1000.00m,
                MaxPrice = 5000.00m,
                OnlyInStock = true
            };

            var queryResult = await controller.QueryProducts(queryFilter) as Microsoft.AspNetCore.Mvc.OkObjectResult;
            var matchedProducts = queryResult?.Value as List<Product> ?? new List<Product>();

            Console.WriteLine($"Filter: Category='{queryFilter.Category}', Price={queryFilter.MinPrice}-{queryFilter.MaxPrice}, InStock={queryFilter.OnlyInStock}");
            Console.WriteLine($"Matched Results Count: {matchedProducts.Count}");
            foreach (var item in matchedProducts)
            {
                Console.WriteLine($" -> [{item.Id}] {item.Name} ({item.Category}) - Rs.{item.Price} | Stock: {item.Stock}");
            }
            Console.WriteLine();
            #endregion

            #region 6. DELETE - Remove Product
            Console.WriteLine("--- 6. [DELETE] Remove Product ---");
            var deleteResult = await controller.Delete(createdId);
            bool isDeleted = deleteResult is Microsoft.AspNetCore.Mvc.NoContentResult;

            var verifyDeletedResult = await controller.GetById(createdId);
            bool isNotFound = verifyDeletedResult is Microsoft.AspNetCore.Mvc.NotFoundObjectResult;

            Console.WriteLine($"Deleted Product ID {createdId} (204 NoContent): {isDeleted}");
            Console.WriteLine($"Verify GET After Delete Returned 404 NotFound: {isNotFound}");
            #endregion

            Console.WriteLine("\n============================================================");
            Console.WriteLine("                  CRUD DEMO COMPLETED                       ");
            Console.WriteLine("============================================================");
        }
    }
}
