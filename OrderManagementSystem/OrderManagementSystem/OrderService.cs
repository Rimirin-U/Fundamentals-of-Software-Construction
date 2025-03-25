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
        public void AddOrder(Order order)
        {
            orders.Add(order);
            Sort(sortByIDOperator);
        }
        public void RemoveOrder(Order order)
        {
            if (!orders.Remove(order)) throw new Exception("RemoveError: order not found");
        }
        public Order SearchByID(string id)
        {

        }
        public List<Order> SearchByNameOfGoods(string name);
        public List<Order> SearchByCustomer(Customer customer);
        public List<Order> SearchByAmount(int min, int max);
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
        private List<Order> orders;
    }
}
