using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>(); 

            var container = containerBuilder.Build();

            var notificationService = container.Resolve<IConsoleNotification>();
            var userService = container.Resolve<UserService>();  

            var user = new User("Bidda");
            userService.ChangeUserName(user, "Abul Hasan");

            Console.ReadKey(); 
        }
    }
}
