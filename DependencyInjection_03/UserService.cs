using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_03
{
    class UserService
    {
        private IConsoleNotification _consoleNotification;
        public UserService( IConsoleNotification consoleNotification)
        {
            _consoleNotification = consoleNotification;
        }
        public void ChangeUserName(User user, string newUserName)
        {
            user.UserName = newUserName;
            _consoleNotification.NotificationUserName(user);
        }
    }
}
