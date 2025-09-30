using CSharp.CommonUtils.Enum;

namespace CSharpLearning.Interfaces
{
    public interface IExecutionService
    {
        Task RunAsync(ExecutionEnum module);
    }
}
