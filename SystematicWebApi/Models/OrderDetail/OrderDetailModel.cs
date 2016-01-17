using SystematicWebApi.Models.Order;
using SystematicWebApi.Models.Products;
using Domain.Entity;

namespace SystematicWebApi.Models.OrderDetail
{
    /// <summary>
    /// 订单详情
    /// </summary>
    public class OrderDetailModel : BaseModel
    {
        public int Quantity { get; set; }
               
        public int OrderId { get; set; }
               
        //public int ProductId { get; set; }

        // Navigation properties
        // 导航属性
        public ProductModel Product { get; set; }

        //public OrderModel Order { get; set; } 
    }
}
