using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrezzieWithDB.Models
{
    public class PrezzieContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}