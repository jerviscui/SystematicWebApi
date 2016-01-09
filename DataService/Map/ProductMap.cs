using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace DataService.Map
{
    public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
            : base("Product")
        {
            this.Property(o => o.Category).IsRequired();
            this.Property(o => o.Name).IsRequired();
            this.Property(o => o.Price).IsRequired();
        }
    }
}
