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
        [StringLength(100, ErrorMessage = "Tên loại sản phẩm không được quá 100 ký tự")]
        [Display(Name = "Tên loại sản phẩm")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Tên nhóm loại sản phẩm không được quá 100 ký tự")]
        [Display(Name = "Nhóm loại sản phẩm")]
        public string GroupType { get; set; }
        [Required]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        public bool Status { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}