using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AirLineReservationService.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Column(TypeName ="Varchar")]
        public string Username { get; set; }
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public string Password { get; set; }
    }
}
