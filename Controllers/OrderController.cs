using Microsoft.AspNet.Identity;
using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroWaveFood.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public List<Cart> TakeCart()
        {
            List<Cart> listCart = Session["Cart"] as List<Cart>;
            if (listCart == null)
            {
                //if list cart doesn't exist, create one
                listCart = new List<Cart>();
                Session["Cart"] = listCart;
            }
            return listCart;
        }
        public int AmountSum()
        {
            int amount = 0;
            List<Cart> list = Session["Cart"] as List<Cart>;
            if (list != null)
            {
                amount = list.Sum(n => n.Amount);
            }
            return amount;
        }

        public long PriceSum()
        {
            long sum = 0;
            List<Cart> list = Session["Cart"] as List<Cart>;
            if (list != null)
            {
                sum = list.Sum(n => n.Total);
            }
            return sum;
        }

        //====================================================================
        // GET: Order
        public ActionResult Payment()
        {
            List<Cart> list = TakeCart();
            Order order = new Order();
            order.UserId = User.Identity.GetUserId();
            order.OrderDate = DateTime.Now;
            order.Status = true;
            order.Total = PriceSum();
            db.Orders.Add(order);
            db.SaveChanges();

            
            foreach (Cart cart in list)
            {
                Product product = db.Products.Find(cart.ProductId);
                if (product == null)
                {
                    ViewBag.Title = "Error when creating Order";
                    ViewBag.Message = "Product not found!";
                    return View("Error");
                }
                Bill bill = new Bill();
                bill.OrderId = order.OrderId;
                bill.ProductId = product.ProductId;
                bill.Amount = cart.Amount;
                bill.Status = true;

                db.Bills.Add(bill);
                db.SaveChanges();
            }
            ViewBag.Title = "Thanh toán thành công!";
            list = null;
            Session["Cart"] = null;
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return View(order);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}