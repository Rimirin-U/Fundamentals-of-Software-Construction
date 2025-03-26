using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    class OrderService
    {
        public OrderService()
        {
            orders = new List<Order>();
        }

        private List<Order> orders;

        public void AddOrder(Order order)
        {
            if (orders.Exists(od => od.Equals(order))) throw new Exception("AddOrderError: order exist");
            orders.Add(order);
            Sort(sortByIDOperator);
        }
        public void RemoveOrder(Order order)
        {
            if (!orders.Remove(order)) throw new Exception("RemoveError: order not found");
        }

        public Order GetByID(int id)
        {
            Order? rt = orders.Find((order) => order.id == id);
            if (rt is null) throw new Exception("GetByIDError: order not found");
            else return rt;
        }
        public List<Order> SearchByNameOfGoods(Goods name)
        {
            var rt = from o in orders where o.orderDetail.goods == name select o;
            return rt.ToList<Order>();
        }
        public List<Order> SearchByCustomer(Customer customer)
        {
            var rt = from o in orders where o.orderDetail.customer == customer select o;
            return rt.ToList<Order>();
        }
        public List<Order> SearchByAmount(int min, int max)
        {
            var rt = from o in orders where o.orderDetail.amount >= min && o.orderDetail.amount <= max select o;
            return rt.ToList<Order>();
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
