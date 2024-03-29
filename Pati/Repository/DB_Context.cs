﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pati.Models;

namespace Pati.Repository
{
    public class DB_Context:DbContext

    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shipment> Shipments { get; set; }




    }
}
