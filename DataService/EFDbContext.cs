using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataService.Map;
using Domain;

namespace DataService
{
    public class EfDbContext : DbContext, IDbContext
    {
        public EfDbContext()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //get all BaseMap subclasses
            var types = Assembly.GetExecutingAssembly().DefinedTypes.Where(type => type.BaseType != null &&
                type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(BaseMap<>));
            foreach (var typeinfo in types)
            {
                dynamic configurationInstance = Activator.CreateInstance(typeinfo);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<T> Table<T>() where T : BaseEntity
        {
            return this.Set<T>();
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
