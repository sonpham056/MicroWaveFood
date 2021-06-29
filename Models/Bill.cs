using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Bill
    {
        [Key]
        [Column(Order = 1)]
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? CommentId { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Comment Comment { get; set; }
    }
}