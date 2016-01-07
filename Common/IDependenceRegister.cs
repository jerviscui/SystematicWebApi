using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Common
{
    public interface IDependenceRegister
    {
        void Register(ContainerBuilder builder);

        int Order();
    }
}
