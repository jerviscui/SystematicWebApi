using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Autofac;
using BaseService;
using Common;
using DataService;

namespace SystematicWebApi.Infrastructure
{
    /// <summary>
    /// use to register dbcontext
    /// </summary>
    public class BasicDependenceRegister : IDependenceRegister
    {
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<EfDbContext>().As<IDbContext>().InstancePerRequest();
            builder.RegisterGeneric(typeof (Repository<>)).As(typeof (IRepository<>)).InstancePerRequest();
        }

        public int Order()
        {
            return 0;
        }
    }
}