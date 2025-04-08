using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    /**
     * The service class to manage orders
     * */
    public class OrderService
    {

        //the order list
        //private List<Order> orders;


        public OrderService()
        {
            //orders = new List<Order>();
        }


        public List<Order> GetAllOrders()
        {
            List<Order> orders;
            using (var db = new OrderDbContext())
            {
                var query = db.Orders;
                orders = query.ToList();
            }
            return orders;
        }


        public Order GetOrder(int id)
        {
            Order order;
            using (var db = new OrderDbContext())
            {
                order = db.Orders.SingleOrDefault(o => o.OrderId == id);
            }
            return order;
        }

        public void AddOrder(Order order)
        {
            using (var db = new OrderDbContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            //if (orders.Contains(order))
            //    throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");
            //orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            using (var db = new OrderDbContext())
            {
                var toDelete = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (toDelete != null)
                {
                    db.Orders.Remove(toDelete);
                    db.SaveChanges();
                }
            }
            //Order order = GetOrder(orderId);
            //if (order != null)
            //{
            //    orders.Remove(order);
            //}
        }

        public List<Order> QueryOrdersByProductName(string productName)
        {
            List<Order> rt;
            using (var db = new OrderDbContext())
            {
                var query = db.Orders
                        .Where(order => order.Details.Exists(item => item.ProductName == productName))
                        .OrderBy(o => o.TotalPrice);
                rt = query.ToList();
            }
            return rt;
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            List<Order> rt;
            using (var db = new OrderDbContext())
            {
                var query = db.Orders
                        .Where(order => order.CustomerName == customerName)
                        .OrderBy(o => o.TotalPrice);
                rt = query.ToList();
            }
            return rt;
        }

        public void UpdateOrder(Order newOrder)
        {
            using(var db = new OrderDbContext())
            {
                var old = db.Orders.Where(o => o.OrderId == newOrder.OrderId);
                if(old is null) throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
                db.Entry(newOrder).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //Order oldOrder = GetOrder(newOrder.OrderId);
            //if (oldOrder == null)
            //    throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
            //orders.Remove(oldOrder);
            //orders.Add(newOrder);
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, GetAllOrders());
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order =>
                {
                    using(var db = new OrderDbContext())
                    {
                        var old = db.Orders.Where(o => o.OrderId == order.OrderId);
                        if (old is null)
                        {
                            db.Orders.Add(order);
                        }
                    }
                    //if (!orders.Contains(order))
                    //{
                    //    orders.Add(order);
                    //}
                });
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            List<Order> rt;
            using (var db = new OrderDbContext())
            {
                var query = db.Orders
                        .Where(order => order.TotalPrice >= amout)
                        .OrderByDescending(o => o.TotalPrice);
                rt = query.ToList();
            }
            return rt;
            //return orders
            //   .Where(order => order.TotalPrice >= amout)
            //   .OrderByDescending(o => o.TotalPrice)
            //   .ToList();
        }
    }
}
