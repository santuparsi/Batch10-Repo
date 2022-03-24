using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Emp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? Joindate { get; set; }
        public string Desig { get; set; }
        public decimal? Salary { get; set; }
        public string DeptId { get; set; }
        public int? Manager { get; set; }
    }
}
