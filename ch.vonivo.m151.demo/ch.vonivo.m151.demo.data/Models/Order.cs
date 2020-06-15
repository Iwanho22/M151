using System;
using System.Collections.Generic;
using System.Text;

namespace ch.vonivo.m151.demo.data.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string OrderName { get; set; }
        public string OrderType { get; set; }
    }
}
