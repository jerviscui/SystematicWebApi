﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OrderDetail : BaseEntity
    {
        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }


        // Navigation properties
        // 导航属性
        public Product Product { get; set; }

        public Order Order { get; set; } 
    }
}
