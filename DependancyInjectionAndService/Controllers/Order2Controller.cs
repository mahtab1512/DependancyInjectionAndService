using DependancyInjectionAndService.Model;
using DependancyInjectionAndService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependancyInjectionAndService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Order2Controller : ControllerBase
    {
        public INotificationService _notificationService { get; set; }
        public ILoggerService _loggerService { get; set; }
        //public OrderController(INotificationService notificationService, ILoggerService loggerService)
        //{
        //    _notificationService = notificationService;
        //    _loggerService = loggerService;
        //}

        [HttpPost(Name = "CreateOrder2")]
        public IActionResult CreateOrder2(Order order)
        {
            // Business logic to create order
            _notificationService = new EmailNotificationService();
            _loggerService = new LoggerService();
            _notificationService.Send("Order created successfully.");
            _loggerService.Log("Order creation logged.");
            return Ok();
        }
    }
}
