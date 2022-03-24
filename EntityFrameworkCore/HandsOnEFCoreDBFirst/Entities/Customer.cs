using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
