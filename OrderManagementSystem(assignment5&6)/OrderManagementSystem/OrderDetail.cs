using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class OrderDetail
    {
        //Constructor
        public OrderDetail(Customer customer, Goods goods)
        {
            this.customer = customer;
            this.goods = goods;
            time = DateTime.Now;
        }

        //Properties
        public Customer customer { get; set; }
        public Goods goods { get; set; }
        public double money { get => goods.price * goods.amount; }
        public DateTime time { get; set; }

        //Functions
        public override bool Equals(object? obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Customer>.Default.Equals(customer, detail.customer) &&
                   EqualityComparer<Goods>.Default.Equals(goods, detail.goods) &&
                   time == detail.time;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(customer, goods, money, time);
        }
        public override string ToString()
        {
            return "OrderDetail:\n" +
                customer + "\n" +
                goods + "\n" +
                $"Money = {money}\n" +
                $"Time = {time}";
        }
    }
}
