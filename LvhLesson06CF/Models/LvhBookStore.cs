using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LvhLesson06CF.Models
{
    public class LvhBookStore : DbContext
    {
        public LvhBookStore() : base("TvcBookStoreConnectionString") { }

        public DbSet<LvhCategory> LvhCategories { get; set; }
        public DbSet<LvhBook> LvhBooks { get; set; }
    }
}
