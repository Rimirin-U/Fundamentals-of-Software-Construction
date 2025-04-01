using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Order
    {
        //Constructor
        public Order(OrderDetail orderDetail, int id)
        {
            this.orderDetail = orderDetail;
            this.id = id;
        }

        //Properties
        public OrderDetail orderDetail { get; set; }
        public int id { get; }

        //Functions
        public override string ToString()
        {
            return $"Order:\n" + orderDetail;
        }
        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   EqualityComparer<OrderDetail>.Default.Equals(orderDetail, order.orderDetail) &&
                   id == order.id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(orderDetail, id);
        }
    }
}
