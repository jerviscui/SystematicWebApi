using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataService
{
    public interface IDbContext
    {
        IDbSet<T> Table<T>() where T : BaseEntity;
        
        void Save();
    }
}
