using System;

namespace FactoryMethod
{
    class NotificationSericeProvider
    {
        public IUserNotifier GetUserNotifier()
        {
// Compiler directive. Don't use for real world applications.
#if DEBUG
            return new TestUserNotifier();
#else
            return new EmailUserNotifier();
#endif
        }
    }
}
