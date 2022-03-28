using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingEF.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int Pid { get; set; }
        public DateTime? OrderDate { get; set; }
        public Product Product { get; set; }
    }
}
