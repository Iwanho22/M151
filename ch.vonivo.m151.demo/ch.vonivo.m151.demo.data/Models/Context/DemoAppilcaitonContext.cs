using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ch.vonivo.m151.demo.data.Models.Context
{
    public class DemoAppilcaitonContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        public DemoAppilcaitonContext(DbContextOptions<DemoAppilcaitonContext> options)
            : base(options)
        { }
    }
}
