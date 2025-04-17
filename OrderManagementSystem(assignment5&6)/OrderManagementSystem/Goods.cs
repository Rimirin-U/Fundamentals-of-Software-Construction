using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Goods
    {
        //Constructor
        public Goods(string kind, double amount, double price)
        {
            this.kind = kind;
            this.amount = amount;
            this.price = price;
        }

        //Properties
        public string kind
        {
            get; set;
        }
        public double amount
        {
            get; set;
        }
        public double price { get; set; }

        //Functions
        public override bool Equals(object? obj)
        {
            return obj is Goods goods &&
                   kind == goods.kind;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(kind);
        }
        public override string ToString()
        {
            return $"Goods:\tKind = {kind}\tAmount = {amount}\tPrice = {price}";
        }
    }
}
