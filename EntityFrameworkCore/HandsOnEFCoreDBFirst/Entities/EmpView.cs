using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class EmpView
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
    }
}
