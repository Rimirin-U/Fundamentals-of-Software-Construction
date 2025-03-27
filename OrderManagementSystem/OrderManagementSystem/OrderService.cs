using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class OrderService
    {
        //Constructor
        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> orders { get; set; }

        private static int maxID = 0;
        private static int GenerateID()
        {
            maxID++;
            return maxID;
        }

        public Order AddOrder(OrderDetail orderDetail)
        {
            if (orders.Find((order) => order.orderDetail.Equals(orderDetail)) is not null) throw new Exception("AddOrderError: order already exists");
            Order norder = new Order(orderDetail, GenerateID());
            orders.Add(norder);
            Sort(sortByIDOperator);
            return norder;
        }
        public void RemoveOrder(Order order)
        {
            if (!orders.Remove(order)) throw new Exception("RemoveError: order not found");
        }

        public List<Order> SearchByID(int id)
        {
            var rt = from o in orders where o.id == id select o;
            return rt.ToList<Order>();
        }
        public List<Order> SearchByGoods(Goods name)
        {
            var lst = from o in orders where o.orderDetail.goods == name select o;
            List<Order> rt = lst.ToList<Order>(); rt.Sort(sortByIDOperator);
            return rt;
        }
        public List<Order> SearchByCustomer(Customer customer)
        {
            var lst = from o in orders where o.orderDetail.customer == customer select o;
            List<Order> rt = lst.ToList<Order>(); rt.Sort(sortByIDOperator);
            return rt;
        }
        public List<Order> SearchByAmount(int min, int max)
        {
            var lst = from o in orders where o.orderDetail.amount >= min && o.orderDetail.amount <= max select o;
            List<Order> rt = lst.ToList<Order>(); rt.Sort(sortByIDOperator);
            return rt;
        }

        public Comparison<Order> sortByAmountOperator
        {
            get => (x, y) =>
        {
            return x.orderDetail.amount > y.orderDetail.amount ? 1 :
            x.orderDetail.amount == y.orderDetail.amount ? 0 : -1;
        };
        }
        public Comparison<Order> sortByIDOperator
        {
            get => (x, y) =>
        {
            return x.id > y.id ? 1 :
            x.id == y.id ? 0 : -1;
        };
        }
        public void Sort() { Sort(sortByIDOperator); }
        public void Sort(Comparison<Order> op)
        {
            orders.Sort(op);
        }
    }
}
