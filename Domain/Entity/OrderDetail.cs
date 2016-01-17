using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OrderDetail : BaseEntity
    {
        public virtual int Quantity { get; set; }
               
        public virtual int OrderId { get; set; }
               
        public virtual int ProductId { get; set; }

        // Navigation properties
        // 导航属性
        public virtual Product Product { get; set; }
               
        public virtual Order Order { get; set; } 
    }
}
