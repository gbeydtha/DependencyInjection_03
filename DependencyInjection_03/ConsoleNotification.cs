using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_03
{
    internal class ConsoleNotification : IConsoleNotification
    {
        public void NotificationUserName(User user)
        {
            Console.WriteLine($"Username has benn changed to : {user.UserName}");
        }
    }
}
