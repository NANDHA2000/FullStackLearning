using CSharp.CommonUtils.Enum;
using CSharpLearning;

namespace Program
{
        public interface IExecutionService
        {
            Task RunAsync(ExecutionEnum module);
        }

        public class ExecutionService : IExecutionService
        {
            public async Task RunAsync(ExecutionEnum module)
            {
                switch(module)
                {
                    case ExecutionEnum.Advanced:
                        ExecutionClass.RunAdvanced();
                        break;
                    case ExecutionEnum.Basics:
                        ExecutionClass.RunBasics();
                        break;
                    case ExecutionEnum.Coding:
                        ExecutionClass.RunCoding();
                        break;
                    case ExecutionEnum.ExpertPatterns:
                        ExecutionClass.RunExpertPatterns();
                        break;
                    case ExecutionEnum.Intermediate:
                        ExecutionClass.RunIntermediate();
                        break;
                    case ExecutionEnum.OOP:
                        ExecutionClass.RunOOP();
                        break;
                    case ExecutionEnum.RealWorld:
                        ExecutionClass.RunRealWorld();
                        break;
                    case ExecutionEnum.Web:
                        await Task.Run(() => ExecutionClass.RunWeb());
                        break;
                    default:
                        throw new ArgumentException("Invalid module");
                }
            }
        }

}
