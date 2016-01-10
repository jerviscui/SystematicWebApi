using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace DataService.Map
{
    public class OrderDetailMap : BaseMap<OrderDetail>
    {
        public OrderDetailMap() : base("OrderDetail")
        {
            //N:1, 
            //todo keep one from this relation and "Order" relation
            this.HasRequired(o => o.Order).WithMany(o => o.OrderDetails).HasForeignKey(o => o.OrderId);
            //1:1
            this.HasRequired(o => o.Product).WithMany().HasForeignKey(o => o.ProductId);

            this.Property(o => o.Quantity).IsRequired();
        }
    }
}
