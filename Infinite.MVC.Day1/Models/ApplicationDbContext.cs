using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Infinite.MVC.Day1.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext():base("MyCon")
        { 

        }

        public DbSet<Product> Products { get; set; }
    }

}