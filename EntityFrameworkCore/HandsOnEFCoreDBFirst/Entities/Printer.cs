using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Printer
    {
        public int PrintId { get; set; }
        public int? PrintCount { get; set; }
    }
}
