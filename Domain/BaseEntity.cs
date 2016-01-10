using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            IsValid = true;
        }

        /// <summary>
        /// Id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public virtual byte[] Timespan { get; set; }

        /// <summary>
        /// 是否有效，假删除
        /// </summary>
        public virtual bool IsValid { get; set; }
    }
}
