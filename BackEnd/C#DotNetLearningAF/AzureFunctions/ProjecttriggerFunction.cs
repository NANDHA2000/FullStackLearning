using CSharp.CommonUtils.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace C_DotNetLearningAF.AzureFunctions
{
    public class ProjecttriggerFunction
    {

        [FunctionName("ProjecttriggerFunction")]
        public async Task<IActionResult> Run(
              [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
               ILogger log)
        {
            try
            {
                string moduleName = req.Query["module"];
                if(string.IsNullOrEmpty(moduleName))
                    return new BadRequestObjectResult("Please provide a module parameter.");

                if(!Enum.TryParse<ExecutionEnum>(moduleName, true, out var moduleEnum))
                    return new BadRequestObjectResult("Invalid module name.");

                var service = new Program.ExecutionService();
                await service.RunAsync(moduleEnum);

                return new OkObjectResult(new
                {
                    success = true,
                    message = $"Module {moduleEnum} executed successfully."
                });
            }
            catch(Exception ex)
            {
                return new ObjectResult(new
                {
                    success = false,
                    message = ex.Message
                })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }

    }
}
