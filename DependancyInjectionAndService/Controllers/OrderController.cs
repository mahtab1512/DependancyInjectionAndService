using DependancyInjectionAndService.Services;
using Microsoft.AspNetCore.Mvc;
using DependancyInjectionAndService.Model;

namespace DependancyInjectionAndService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly ILoggerService _loggerService;
        private readonly OrderService _orderService;
        private readonly IConfiguration _configuration;


        public OrderController(IConfiguration configuration,INotificationService notificationService, ILoggerService loggerService, OrderService orderService)
        {
            _notificationService = notificationService;
            _loggerService = loggerService;
            _orderService = orderService;
            _configuration = configuration;
        }

        [HttpPost(Name = "CreateOrder")]
        public IActionResult CreateOrder(Order order)
        {
            // Business logic to create order
            _notificationService.Send("Order created successfully.");
            _loggerService.Log("Order creation logged.");
            _orderService.PlaceOrder(order);
            return Ok();
        }
    }
}
