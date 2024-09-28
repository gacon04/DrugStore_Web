using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DrugStore_Web.Models
{
    public class DrugStoreDBContext: DbContext
    {
        public DrugStoreDBContext() : base("DSConnectionString") {  }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ContactMess> ContactMesses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}