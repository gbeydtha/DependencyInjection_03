using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_03
{
    internal class User
    {

        public User(string username)
        {
            UserName = username;

        }
        public string UserName { get; set; }

        //private IConsoleNotification _consoleNotification;
        //public User(string username, IConsoleNotification consoleNotification)
        //{
        //    UserName = username;
        //    _consoleNotification = consoleNotification;
        //}
        //public string UserName { get; set; }

        //public void ChangeUserName(string newUserName)
        //{
        //    UserName = newUserName;
        //    _consoleNotification.NotificationUserName(this);
        //}
    }
}
