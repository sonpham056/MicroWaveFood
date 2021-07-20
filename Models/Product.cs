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
        [Display(Name = "Tên loại sản phẩm")]
        public int ProductTypeId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Tên không được quá 100 ký tự")]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Mô tả sản phẩm không được quá 1000 ký tự")]
        [Display(Name = "Mô tả sản phẩm")]
        public string ProductDescribe { get; set; }
        [Required]
        [Display(Name = "Gía sản phẩm")]
        [Range(1000, 100000000)]
        public long Price { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Đơn vị sản phẩm không được quá 50 ký tự")]
        public string Unit { get; set; }
        [Required]
        [Display(Name = "Ngày nhập hàng")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Required]
        [Range(1, 100000000)]
        public int Quantity { get; set; }
        [Required]
        public bool status { get; set; }
        [Required]
        [Display(Name = "Nguồn gốc xuất xứ")]
        [StringLength(50, ErrorMessage = "Nguồn gốc xuất xứ không được quá 50 ký tự")]
        public string Origin { get; set; }
        public ProductType ProductType { get; set; }

        public virtual List<Bill> Bills { get; set; }

        public int? SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}