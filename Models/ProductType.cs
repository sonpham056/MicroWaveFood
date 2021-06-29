using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class ProductType
    {
        [Key]
        [Column(Order = 1)]
        public int ProductTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GroupType { get; set; }
        [Required]
        public string Image { get; set; }
        public bool Status { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}