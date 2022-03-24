using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCoreDBFirst_Demo2.Entities
{
    [Table("Products")]
    class Product
    {
        [Key] //primary key will set and identity is applied
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName ="varchar")] //set datatype
        [StringLength(30)]
        public string ProductName { get; set; }
       
        [Column(TypeName = "varchar")] //set datatype
        [StringLength(30)]
        public string Description { get; set; }
        public double? Price { get; set; } //Null constraint will be applied
    }
}
