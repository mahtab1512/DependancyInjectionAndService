using DependancyInjectionAndService.Model;

namespace DependancyInjectionAndService.Services
{
    public interface IOrderService
    {
        void PlaceOrder(Order order);
    }
}
