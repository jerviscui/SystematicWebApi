using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystematicWebApi.Models.OrderDetail;
using BaseService;
using Domain.Entity;

namespace SystematicWebApi.Controllers
{
    /// <summary>
    /// 订单详情
    /// </summary>
    public class OrderDetailController : ApiController
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDetailModel GetOrderDetail(int id)
        {
            return _orderDetailService.GetOrderDetail(id).ToModel();
        }

        ///// <summary>
        ///// 获取订单详情
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public OrderDetail GetOrderDetail(int id)
        //{
        //    return _orderDetailService.GetOrderDetail(id);
        //}
    }
}
