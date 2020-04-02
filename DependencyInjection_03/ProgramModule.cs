using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_03
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotification>().As<IConsoleNotification>();
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}
