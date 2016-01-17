using System.Collections.Generic;
using SystematicWebApi.Models.OrderDetail;

namespace SystematicWebApi.Models.Order
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderModel : BaseModel
    {
        public string Customer { get; set; }

        // Navigation property
        // 导航属性
        public IList<OrderDetailModel> OrderDetails { get; set; } 
    }
}
