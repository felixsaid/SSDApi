using SSDApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SSDApp.Services
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Entities")
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<Household> households { get; set; }
        public DbSet<Children> childrens { get; set; }
    }
}