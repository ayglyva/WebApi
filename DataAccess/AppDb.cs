using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDb : DbContext
    {
        public DbSet<OrderClass> Orders { get; set; }

        public AppDb( DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
         var x=Database.GenerateCreateScript();
        }
    }
}
