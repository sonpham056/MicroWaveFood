using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        [Required]
        [Display(Name = "Tên mã giảm giá")]
        [StringLength(100, ErrorMessage = "Tên mã giảm giá không được quá 100 ký tự")]
        public string SaleName { get; set; }
        [Required]
        [Range(0, 100)]
        [Display(Name = "Phần trăm giảm giá (thang 100)")]
        public int SaleRate { get; set; }
        [Required]
        [ValidDate]
        [Display(Name = "Từ ngày")]
        public DateTime From { get; set; }
        [Required]
        [Display(Name = "Đến ngày")]
        public DateTime To { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Nội dung không quá 1000 ký tự")]
        [Display(Name = "Nội dung giảm giá")]
        public string SaleContent { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}