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
        public OrderDetail(Customer customer, Goods goods,int amount)
        {
            this.customer = customer;
            this.goods = goods;
            this.amount = amount;
            time = DateTime.Now;
        }

        //Properties
        public Customer customer { get; set; }
        public Goods goods { get; set; }
        public int amount { get; set; }
        public DateTime time { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Customer>.Default.Equals(customer, detail.customer) &&
                   EqualityComparer<Goods>.Default.Equals(goods, detail.goods) &&
                   amount == detail.amount &&
                   time == detail.time;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(customer, goods, amount, time);
        }

        //Functions

        public override string ToString()
        {
            return "OrderDetail:\n" +
                customer + "\n" +
                goods + "\n" +
                $"Amount = {amount}" +
                $"Time = {time}";
        }

       
    }
}
