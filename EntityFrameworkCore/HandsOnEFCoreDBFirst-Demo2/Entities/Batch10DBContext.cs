using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCoreDBFirst_Demo2.Entities
{
    class Batch10DBContext:DbContext
    {
        //Entity sets
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SANTU\MSSQLSERVER2019;Database=Batch10DB;Integrated Security=true");
        }
    }
}
