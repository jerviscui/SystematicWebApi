using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataService
{
    public interface IDbContext<T> where T : BaseEntity
    {
        IDbSet<T> Table { get; }

        void Save();
    }
}
