using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEFCoreDBFirst_Demo2.Entities
{
    [Table("Orders")]
    class Order
    {
        //Scalar Properties(used to define columns)
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Product")] //making relation with ProductId in Product entity
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; } //Navigation Properties(used to define fk relations)
    }
}
