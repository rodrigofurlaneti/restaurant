namespace Restaurant.Domain.SeedWork
{
    public class Logger : ILogger
    {
        public string? _logger { get; set; }

        public void TraceEntry(string? message)
        {
            this._logger = message;
        }
        public void TraceExit(string? message)
        {
            this._logger = message;
        }

        public void TraceException(string? message)
        {
            this._logger = message;
        }
    }
}
