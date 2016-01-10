using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace DataService.Map
{
    public class OrderMap : BaseMap<Order>
    {
        public OrderMap() : base("Order")
        {
            this.Property(o => o.Customer).IsRequired();

            //N:1, 
            //todo keep one from this relation and "Order" relation
            this.HasMany(o => o.OrderDetails).WithRequired(o => o.Order).HasForeignKey(o => o.OrderId);

            //this.Ignore(o => o.OrderDetails);
        }
    }
}
