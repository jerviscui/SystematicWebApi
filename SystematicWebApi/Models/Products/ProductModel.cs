using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystematicWebApi.Models.Products
{
    /// <summary>
    /// 产品
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
    }
}