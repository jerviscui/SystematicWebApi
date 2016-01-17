using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;
using Domain.Entity;

namespace BaseService
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IList<Order> GetOrders()
        {
            //return _orderRepository.Table.Include(o => o.OrderDetails).Where(o => o.IsValid).ToList();
            return _orderRepository.Table.Where(o => o.IsValid).ToList();
        }
    }
}
