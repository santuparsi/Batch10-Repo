using System;
using HandsOnEFCoreDBFirst.Entities;
using System.Collections.Generic;
using System.Linq;
namespace HandsOnEFCoreDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Training1DBContext db = new Training1DBContext();
            List<Employee> employees = db.Employees.ToList();
            foreach(var item in employees)
            {
                Console.WriteLine("{0} {1} {2}", item.Eid, item.Ename, item.Desig);
            }
        }
    }
}
