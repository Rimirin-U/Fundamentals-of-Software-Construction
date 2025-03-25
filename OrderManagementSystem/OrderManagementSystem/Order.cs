﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Order
    {
        //Constructor
        public Order(OrderDetail orderDetail)
        {
            this.orderDetail = orderDetail;
            id = GenerateID();
        }

        //Properties
        public OrderDetail orderDetail { get; set; }
        public int id { get; }

        //ID
        private static int maxID = 0;
        private static int GenerateID()
        {
            maxID++;
            return maxID;
        }

        //Functions
        public override string ToString()
        {
            return $"Order:\n" + orderDetail;
        }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   EqualityComparer<OrderDetail?>.Default.Equals(orderDetail, order.orderDetail);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(orderDetail);
        }
    }
}
