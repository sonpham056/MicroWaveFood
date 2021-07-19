using MicroWaveFood.Models;
using MicroWaveFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroWaveFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public int AmountSum()
        {
            int amount = 0;
            //List<Cart> list = Session["Cart"] as List<Cart>;
            List<Cart> list = ListCart.Carts;
            if (list != null)
            {
                amount = list.Sum(n => n.Amount);
            }
            return amount;
        }

        public long PriceSum()
        {
            long sum = 0;
            //List<Cart> list = Session["Cart"] as List<Cart>;
            List<Cart> list = ListCart.Carts;
            if (list != null)
            {
                sum = list.Sum(n => n.Total);
            }
            return sum;
        }

        //===============================================
        [Authorize(Roles = "admin")]
        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult Index()
        {
            if (User.IsInRole("admin"))
            {
                return RedirectToAction("AdminIndex");
            }
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            List<Product> bestSeller = new List<Product>();
            List<Product> random = new List<Product>();
            var HomeViewModel = new HomeIndexViewModel
            {

                ProductTypes = db.productTypes
                .Where(a => a.Status == true)
                .ToList(),


                ProductList = db.Products.Include("Sale").Where(a => a.status == true).ToList(),
                BestSellerList = db.Products
                .Include("Sale")
                .Where(a => a.status == true)
                .Where(a => a.Bills.Count > 3)
                .Take(10)
                .ToList(),

                ListRandom = db.Products.Include("Sale").Where(a => a.status == true).OrderBy(a => Guid.NewGuid()).Take(5).ToList(),

                GroupTypes = new List<string>() { "Đồ làm bánh", "Đồ nấu ăn", "Đồ pha chế" }

            };
            return View(HomeViewModel);
        }
        //=========================
        public ActionResult About()
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
      
    }
}