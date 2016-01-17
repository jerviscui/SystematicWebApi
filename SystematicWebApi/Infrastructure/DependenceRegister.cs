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
            //Uncomment the following RegisterType to use static data memfor test
            //builder.RegisterType<NoDbProductService>().As<IProductService>().InstancePerLifetimeScope();

            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
            builder.RegisterType<OrderDetailService>().As<IOrderDetailService>().InstancePerLifetimeScope();
        }

        public int Order()
        {
            return 2;
        }
    }
}