using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Order
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public long? Total { get; set; }
        public bool? IsDelivered { get; set; }
        public bool Status { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}