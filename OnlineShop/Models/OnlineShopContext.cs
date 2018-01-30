using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineShop.Models;
using OnlineShop.Models.AnotherModels;

namespace OnlineShop.Models
{
    public class OnlineShopContext:DbContext
    {
        public OnlineShopContext() : base("OnlineShopContext") { }

        public DbSet<Console> Consoles { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<PC> PCS { get; set; }
        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
        public DbSet<SecreatCombinations> SecreatCombinations { get; set; }
        public DbSet<Manager> Managers { get; set; }
        


    }
}