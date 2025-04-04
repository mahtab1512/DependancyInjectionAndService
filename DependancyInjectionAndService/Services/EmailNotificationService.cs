namespace DependancyInjectionAndService.Services
{
    // Implement the interfaces
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Logic to send email
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
