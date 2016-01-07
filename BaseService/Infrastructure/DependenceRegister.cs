using Autofac;
using Common;
using Domain;

namespace BaseService.Infrastructure
{
    public class DependenceRegister : IDependenceRegister
    {
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRespository>().As<IProductRespository>().InstancePerRequest();
        }

        public int Order()
        {
            return 1;
        }
    }
}