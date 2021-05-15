using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MicroWaveFood.DAL
{
    public class Product_type_context : DbContext
    {
        public Product_type_context() : base("Product_type_context")
        {
            
        }
        public DbSet<ProductType> productTypes { get; set; }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}