using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Order : BaseEntity
    {
        //public Order()
        //{
        //    OrderDetails = new List<OrderDetail>();
        //}

        public virtual string Customer { get; set; }

        // Navigation property
        // 导航属性
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } 
    }
}
