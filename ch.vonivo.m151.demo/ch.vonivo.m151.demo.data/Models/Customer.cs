using System;
using System.Collections.Generic;
using System.Text;

namespace ch.vonivo.m151.demo.data.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
