using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroWaveFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<ProductType> ProductTypes { get; set; }
        public List<Product> ProductList { get; set; }
        public List<Product> BestSellerList { get; set; }
        public List<Product> ListRandom { get; set; }

        public List<string> GroupTypes;
    }
}