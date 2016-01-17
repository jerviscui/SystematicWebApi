using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SystematicWebApi.App_Start;
using SystematicWebApi.Infrastructure;
using SystematicWebApi.Models;
using Autofac;
using Autofac.Integration.WebApi;
using Newtonsoft.Json;

namespace SystematicWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.Config();
            ContextConfig.Initialize(GlobalConfiguration.Configuration);

            //circular reference for json formatter
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = 
                PreserveReferencesHandling.Objects;
            //todo: circular reference for xml formatter?
            //....

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TestContext>());
        }
    }
}
