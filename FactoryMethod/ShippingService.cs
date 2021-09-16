using System;

namespace FactoryMethod
{
    class ShippingService
    {
        NotificationSericeProvider _serviceProvider;

        public ShippingService(NotificationSericeProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShipItem()
        {
            //code to ship item

            _serviceProvider.GetUserNotifier().NotifyUser(1);
        }
    }
}
