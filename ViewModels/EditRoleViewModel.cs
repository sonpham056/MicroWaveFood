using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicroWaveFood.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<string> Users { get; set; }

        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
    }
}