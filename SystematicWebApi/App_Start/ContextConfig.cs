using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using BaseService;
using Common;

namespace SystematicWebApi.App_Start
{
    public static class ContextConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            

            //some base interface register
            //like dbcontext IRespository

            IList<Assembly> assemblies = new List<Assembly>()
            {
                Assembly.Load("BaseService"),
                Assembly.Load("SystematicWebApi")
            };

            var types = new List<Type>();
            foreach (var item in assemblies)
            {
                types.AddRange(item.DefinedTypes.Where(o => typeof(IDependenceRegister).IsAssignableFrom(o)));
            }

            var registers = types.Select(type => 
                type.Assembly.CreateInstance(type.FullName) as IDependenceRegister).ToList();
            registers = registers.OrderBy(o => o.Order()).ToList();

            foreach (var register in registers)
            {
                register.Register(builder);
            }
            var assembly = Assembly.GetCallingAssembly();
            builder.RegisterApiControllers(assembly);
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));
        }
    }
}