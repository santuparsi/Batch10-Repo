using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandOnEFCodeFirst_Demo1.Entities
{
    class Batch10DBContext:DbContext
    {
        //entity set
        public DbSet<Student> Students { get; set; }
        //Conntection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SANTU\MSSQLSERVER2019;Database=Batch10DB;Integrated Security=true");
        }
    }
}
