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
        public string ProductName { get; set; }
        public long Price { get; set; }
        public string Unit { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public bool status { get; set; }
        public string Origin { get; set; }
        public ProductType ProductType { get; set; }

        public virtual List<Bill> Bills { get; set; }
    }
}