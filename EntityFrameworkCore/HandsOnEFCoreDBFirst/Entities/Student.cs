using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public DateTime? Sdob { get; set; }
        public string StandId { get; set; }

        public virtual Standard Stand { get; set; }
    }
}
