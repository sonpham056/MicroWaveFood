using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Product
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescribe { get; set; }
        [Required]
        public long Price { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool status { get; set; }
        [Required]
        public string Origin { get; set; }
        public ProductType ProductType { get; set; }

        public virtual List<Bill> Bills { get; set; }
    }
}