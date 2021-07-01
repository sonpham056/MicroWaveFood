using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroWaveFood.Controllers
{
    [Authorize]
    public class CartController : Controller
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

        public ActionResult AddToCart(int productId, string strUrl, bool? isMinus)
        {
            //take cart
            List<Cart> list = TakeCart();
            //check if this product is in session["cart"]
            Cart cart = list.Find(a => a.ProductId == productId);
            if (cart == null)
            {
                cart = new Cart(productId);
                list.Add(cart);
                return Redirect(strUrl);
            }
            else if (isMinus != null)
            {
                cart.Amount--;
                return Redirect(strUrl);
            } 
            else 
            {
                cart.Amount++;
                return Redirect(strUrl);
            }
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

        public ActionResult Cart()
        {
            List<Cart> list = TakeCart();
            if (list.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return View(list);
        }

        public ActionResult CartDelete(int productId)
        {
            List<Cart> list = TakeCart();
            Cart cart = list.SingleOrDefault(n => n.ProductId == productId);
            if (cart != null)
            {
                list.RemoveAll(n => n.ProductId == productId);
                return RedirectToAction("Cart");
            }
            if (list.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return  RedirectToAction("Cart");
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CartPartial()
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return PartialView();
        }
    }
}