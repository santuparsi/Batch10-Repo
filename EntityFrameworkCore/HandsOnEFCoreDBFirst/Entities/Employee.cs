using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            InverseManagerNavigation = new HashSet<Employee>();
            Logins = new HashSet<Login>();
        }

        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? Joindate { get; set; }
        public string Desig { get; set; }
        public decimal? Salary { get; set; }
        public string DeptId { get; set; }
        public int? Manager { get; set; }

        public virtual Dept Dept { get; set; }
        public virtual Employee ManagerNavigation { get; set; }
        public virtual ICollection<Employee> InverseManagerNavigation { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
