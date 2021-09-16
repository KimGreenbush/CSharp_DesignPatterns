using System;

namespace FactoryMethod
{
    class EmailUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Notified Use {id} By Email.");
        }
    }
}
