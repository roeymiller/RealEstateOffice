using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RealEstateOffice.Models
{
    public class MyDB : DbContext
    {
        public DbSet<Customer> customers { get; set; }

        public DbSet<Deal> deals { get; set; }

        public DbSet<Property> properties { get; set; }

        public DbSet<Broker> brokers { get; set; }

    }
}
