using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystematicWebApi.Models.Products
{
    /// <summary>
    /// 产品
    /// </summary>
    public class ProductModel : BaseModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [Required]
        public string Category { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [Required]
        public decimal Price { get; set; }
    }
}