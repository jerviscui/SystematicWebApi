using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Autofac;
using BaseService;
using Common;

namespace SystematicWebApi.Infrastructure
{
    public class DependenceRegister : IDependenceRegister
    {
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
        }

        public int Order()
        {
            return 0;
        }
    }
}