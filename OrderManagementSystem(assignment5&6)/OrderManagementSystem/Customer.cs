using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Customer
    {
        //Constructor
        public Customer(string name)
        {
            this.name = name;
        }

        //Properties
        public string name { get; set; }


        //Functions
        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   name == customer.name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }
        public override string ToString()
        {
            return $"Customer:\tName = {name}";
        }
    }
}
