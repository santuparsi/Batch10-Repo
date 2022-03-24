using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Person
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? JoinDate { get; set; }
    }
}
