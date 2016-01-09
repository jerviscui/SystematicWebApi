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
        public int Id { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public byte[] Timespan { get; set; }

        /// <summary>
        /// 是否有效，假删除
        /// </summary>
        public bool IsValid { get; set; }
    }
}
