using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Map;
using Domain;

namespace DataService
{
    public class EfDbContext<T> : DbContext, IDbContext<T> where T : BaseEntity
    {
        public EfDbContext()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }
        
        IDbSet<T> IDbContext<T>.Table
        {
            get { return this.Set<T>(); }
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
