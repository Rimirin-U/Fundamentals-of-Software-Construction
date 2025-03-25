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
        public Goods(string kind)
        {
            this.kind = kind;
        }

        //Properties
        public string kind { get; set; }

        //Functions
        public override string ToString()
        {
            return $"Goods:\tKind = {kind}";
        }
    }
}
