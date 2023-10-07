using mf.domain.Commands.Contracts;
using System.Net;

namespace mf.domain.Commands
{
    public class CommandResult<T> : ICommandResult
    {
        public T Data { get; }
        public List<string> Errors { get; }
        public HttpStatusCode Status { get; }

        public CommandResult(T data, List<string>? errors = null, HttpStatusCode status = HttpStatusCode.OK)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Data cannot be null.");
            }

            Data = data;
            Errors = errors ?? new List<string>();
            Status = status;
        }

        public object data { get; set; }
        public List<string> errors { get; set; } = new();

        public HttpStatusCode status { get; set; }
    }
}