using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystematicWebApi.Models.Order;
using BaseService;
using Domain.Entity;

namespace SystematicWebApi.Controllers
{
    /// <summary>
    /// 订单接口
    /// </summary>
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
        public IList<OrderModel> GetOrders()
        {
            return _orderService.GetOrders().Select(o => o.ToModel()).ToList();
        }
    }
}
