using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroWaveFood.ViewModels
{
    public class SaleViewModel
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool IsSelected { get; set; }
    }
}