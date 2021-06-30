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
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Phường/xã quá dài")]
        public string Guild { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Địa chỉ quá dài!")]
        public string Address { get; set; }
    }
}