using DotNetMastery.CommonUtils.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMastery.RealWorld.RestAPIs
{
    public class RestApiCrud
    {

        [ApiController]
        [Route("api/[controller]")]
        public class ProductsController : ControllerBase
        {
            private readonly DbHelper _dbHelper;

            public ProductsController(DbHelper dbHelper)
            {
                _dbHelper = dbHelper;
            }

            // 1. GET: api/products
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var products = await _dbHelper.GetAllAsync();
                return Ok(products);
            }

            // 2. GET: api/products/5
            [HttpGet("{id:int}")]
            public async Task<IActionResult> GetById(int id)
            {
                var product = await _dbHelper.GetByIdAsync(id);
                return product is not null ? Ok(product) : NotFound(new { Message = $"Product with ID {id} not found." });
            }

            // 3. POST: api/products
            [HttpPost]
            public async Task<IActionResult> Create([FromBody] Product product)
            {
                int newId = await _dbHelper.CreateAsync(product);
                product.Id = newId;
                return CreatedAtAction(nameof(GetById), new { id = newId }, product);
            }

            // 4. PUT: api/products/5 (Full replacement)
            [HttpPut("{id:int}")]
            public async Task<IActionResult> Update(int id, [FromBody] Product product)
            {
                bool updated = await _dbHelper.UpdateAsync(id, product);
                return updated ? NoContent() : NotFound(new { Message = $"Product with ID {id} not found." });
            }

            // 5. PATCH: api/products/5 (Partial update for Price/Stock/IsActive)
            [HttpPatch("{id:int}")]
            public async Task<IActionResult> Patch(int id, [FromBody] ProductPatchDto patchDto)
            {
                bool patched = await _dbHelper.PatchAsync(id, patchDto);
                return patched ? NoContent() : NotFound(new { Message = $"Product with ID {id} not found." });
            }

            // 6. DELETE: api/products/5
            [HttpDelete("{id:int}")]
            public async Task<IActionResult> Delete(int id)
            {
                bool deleted = await _dbHelper.DeleteAsync(id);
                return deleted ? NoContent() : NotFound(new { Message = $"Product with ID {id} not found." });
            }

            // 7. QUERY: api/products/search (Safe, idempotent search with JSON body)
            [AcceptVerbs("QUERY")]
            [Route("search")]
            public async Task<IActionResult> QueryProducts([FromBody] ProductQueryRequest queryRequest)
            {
                var results = await _dbHelper.ExecuteQueryAsync(queryRequest);
                return Ok(results);
            }
        }
    }
}
