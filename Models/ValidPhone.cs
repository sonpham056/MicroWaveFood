using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MicroWaveFood.Models
{
    public class ValidPhone : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Regex.Match(value.ToString(), @"^0[0-9]{9}$").Success;
        }
    }
}