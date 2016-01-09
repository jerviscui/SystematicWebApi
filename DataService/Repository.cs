using System;
using System.Data.Entity;
using Domain;

namespace DataService
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext<T> _dbContext;

        public Repository(IDbContext<T> dbContext)
        {
            _dbContext = dbContext;
        }

        public IDbSet<T> Table { get { return _dbContext.Table; } }

        public void Add(T model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            _dbContext.Table.Add(model);
            Save();
        }

        public void Update(T model)
        {
            _dbContext.Table.Attach(model);
            Save();
        }

        public void Delete(T model)
        {
            model.IsValid = false;
            this.Update(model);
            Save();
        }

        public void Remove(T model)
        {
            _dbContext.Table.Remove(model);
            Save();
        }

        private void Save()
        {
            _dbContext.Save();
        }
    }
}
