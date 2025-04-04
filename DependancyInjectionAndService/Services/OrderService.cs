using DependancyInjectionAndService.Model;

namespace DependancyInjectionAndService.Services
{
    public class OrderService// : IOrderService
    {
        private readonly Guid _guid;
        private readonly INotificationService _notificationService;
        private readonly IConfiguration _configuration;
        public OrderService(IConfiguration configuration, INotificationService notificationService)
        {
            _guid = Guid.NewGuid();
            _notificationService = notificationService;
            _configuration= configuration;
        }

        public void PlaceOrder(Order order)
        {
            // Use _guid to track operations within the same request
            var AllowedHosts = _configuration.GetValue<string>("AllowedHosts");
            Console.WriteLine("AllowedHosts -  " + AllowedHosts);
            _notificationService.Send("LLLLLLLLHHHHHHHHH");
            Console.WriteLine($"Order placed with service ID: {_guid}");
        }
    }
}
