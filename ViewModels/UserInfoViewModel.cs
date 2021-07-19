using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicroWaveFood.ViewModels
{
    public class UserInfoViewModel
    {
        [Required]
        [Display(Name ="Họ và tên")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [ValidPhone]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Tỉnh/TP")]
        public string Province { get; set; }
        [Required]
        [Display(Name = "Quận, xã huyện")]
        public string District { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Phường/xã quá dài")]
        [Display(Name = "Phường")]
        public string Guild { get; set; }
        [Required]
        [Display(Name = "Địa chỉ")]
        [StringLength(255, ErrorMessage = "Địa chỉ quá dài!")]
        public string Address { get; set; }
    }
}