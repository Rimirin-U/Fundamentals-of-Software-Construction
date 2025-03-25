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
        public override string ToString()
        {
            return $"Customer:\tName = {name}";
        }
    }
}
