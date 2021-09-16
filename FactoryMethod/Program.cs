using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationServiceProvider = new NotificationSericeProvider();
            var shippingService = new ShippingService(notificationServiceProvider);
            shippingService.ShipItem();
        }
    }
}
