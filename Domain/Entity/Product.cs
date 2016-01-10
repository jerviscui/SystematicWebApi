using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public virtual string Category { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public virtual decimal Price { get; set; }
    }
}
