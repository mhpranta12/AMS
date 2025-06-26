using AMS.Core.Interfaces;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Service.Modules
{
    public class ServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
                builder.RegisterType<AccountService>().As<IAccountService>()
                    .InstancePerLifetimeScope();
        }
    }
}
