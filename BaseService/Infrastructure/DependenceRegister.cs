using Autofac;
using Common;
using Domain;

namespace BaseService.Infrastructure
{
    public class DependenceRegister : IDependenceRegister
    {
        public void Register(ContainerBuilder builder)
        {
            //Uncomment the following RegisterType to use static data memfor test
            //builder.RegisterType<ProductRespository>().As<IProductRespository>().InstancePerRequest();
        }

        public int Order()
        {
            return 1;
        }
    }
}