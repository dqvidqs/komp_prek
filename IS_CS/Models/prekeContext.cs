using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IS_CS.Models
{
    public class prekeContext : DbContext
    {
        public DbSet<preke> prekes { get; set; }
    }
}