namespace Restaurant.Domain.SeedWork
{
    public interface ILogger
    {
        void TraceEntry(string? message);
        void TraceExit(string? message);
        void TraceException(string? message);
    }
}
