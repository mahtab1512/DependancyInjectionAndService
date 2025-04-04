namespace DependancyInjectionAndService.Services
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            // Logic to log messages
            Console.WriteLine($"Log entry: {message}");
        }
    }
}
