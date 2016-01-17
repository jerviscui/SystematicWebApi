using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataService.Map
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap(string table)
        {
            this.ToTable(table);

            HasKey(o => o.Id);
            this.Property(o => o.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(o => o.Timespan).IsRowVersion().IsRequired();
            //todo: EF 7.0 has property default value method?
            this.Property(o => o.IsValid).IsRequired();
        }
    }
}
