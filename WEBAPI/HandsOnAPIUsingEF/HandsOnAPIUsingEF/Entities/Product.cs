using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEF.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        [Required]
        [StringLength(20)]
        public string Pname { get; set; }
        [Column(TypeName ="Money")]
        public double? Price { get; set; }
        public int? Stock { get; set; }
       
    }
}
