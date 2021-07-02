using System.Threading.Tasks;

namespace Homework2
{
    public static class CommandExecution
    {
        public static Error Fail(ErrorCode errorCode, string errorMessage = null)
        {
            var result = new Error
            {
                Code = (int)errorCode,
                Message = errorMessage ?? string.Empty
            };

            return result;
        }
    }
}
