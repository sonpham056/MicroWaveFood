using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroWaveFood.Models
{
    public class Cart
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public long ProductPrice { get; set; }
        public int Amount { get; set; }
        public long Total { get { return Amount * ProductPrice; } }

        public Cart()
        {

        }

        public Cart(int productId)
        {
            ProductId = productId;
            Product product = db.Products.Where(a => a.status == true).Single(a => a.ProductId == ProductId);
            ProductName = product.ProductName;
            ProductImage = product.Image;
            ProductPrice = product.Price;
            Amount = 1;
        }
    }
}