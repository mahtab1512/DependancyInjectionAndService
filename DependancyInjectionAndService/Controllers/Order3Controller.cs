using DependancyInjectionAndService.Model;
using DependancyInjectionAndService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependancyInjectionAndService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Order3Controller : ControllerBase
    {

        private readonly ILoggerService _loggerService;

        public Order3Controller(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        [HttpPost(Name = "CreateOrder3")]
        public IActionResult CreateOrder3(Order order, [FromServices] INotificationService notificationService)
        {
            // Business logic to create order
            notificationService.Send("Order created successfully.");
            _loggerService.Log("Order creation logged.");
            return Ok();
        }

    }
}
