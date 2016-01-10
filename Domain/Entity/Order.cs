using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Order : BaseEntity
    {
        public virtual string Customer { get; set; }

        // Navigation property
        // 导航属性
        public ICollection<OrderDetail> OrderDetails { get; set; } 
    }
}
