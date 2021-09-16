using System;

namespace FactoryMethod
{
    class TestUserNotifier: IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Pretending to notify User {id}.");
        }
    }
}
