using Microsoft.AspNet.Identity;
using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net.Mail;
using System.Net;

namespace MicroWaveFood.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public List<Cart> TakeCart()
        {
            //List<Cart> listCart = Session["Cart"] as List<Cart>;
            List<Cart> listCart = ListCart.Carts;
            if (listCart == null)
            {
                //if list cart doesn't exist, create one
                listCart = new List<Cart>();
                ListCart.Carts = listCart;
                //Session["Cart"] = listCart;
            }
            return listCart;
        }
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

        //====================================================================
        // GET: Order
        public ActionResult Payment()
        {
            List<Cart> list = TakeCart();
            Order order = new Order();
            order.UserId = User.Identity.GetUserId();
            order.OrderDate = DateTime.Now;
            order.Status = true;
            order.IsDelivered = false;
            order.Total = PriceSum();
            db.Orders.Add(order);
            db.SaveChanges();

            string _body = "";
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


                _body += "Tên sản phẩm: " + cart.ProductName.ToString();
                _body += " - Giá: " + cart.ProductPrice.ToString();
                _body += " - Số lượng: " + cart.Amount.ToString();
                _body += " - thành tiền: " + (cart.ProductPrice * cart.Amount).ToString();
                _body += "\n";
                db.SaveChanges();
            }

            _body += "\n Tổng tiền: " + order.Total.ToString();
            ViewBag.Title = "Thanh toán thành công! Chúng tôi sẽ giao hàng cho quí khách trong thời gian sớm nhất!";


            var user = db.Users.Find(User.Identity.GetUserId());

            var mail = user.Email.ToString();
            
            string _subject = "Đơn hàng từ Microwave Food đây :v";

            var mailInfo = new MailInfo { To = mail, Body = _body, Subject = _subject };
            SendMail(mailInfo);

            list = null;
            //Session["Cart"] = null;
            ListCart.Carts = null;
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            

            return View(order);
        }

        public void SendMail(MailInfo emailInfo)
        {
            string email = "microwavefood.https@gmail.com";
            string password = "Microwave123";
            using (MailMessage m = new MailMessage(email, emailInfo.To))
            {
                m.Subject = emailInfo.Subject;
                m.Body = emailInfo.Body;
                
                m.IsBodyHtml = false;
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    
                    NetworkCredential networkCred = new NetworkCredential(email, password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCred;
                    smtp.Port = 587;
                    smtp.Send(m);
                    ViewBag.Message = "Sent";
                }
            }
        }

        public ActionResult History(int? type)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            if (user == null)
            {
                ViewBag.Message = "Vui lòng đăng nhập!";
                return View("Error");
            }
            List<Order> list = new List<Order>();
            if (type == null)
            {
                list = db.Orders.Include("Bills.Product").Where(a => a.Status == true && a.UserId == user.Id)
                    .OrderByDescending(a => a.OrderDate).ToList();
            }
            else if (type == 1) //1 = chưa giao
            {
                list = db.Orders.Include("Bills.Product").Where(a => a.Status == true && a.IsDelivered == false && a.UserId == user.Id)
                    .OrderByDescending(a => a.OrderDate).ToList();
            }
            else //còn lại = đã giao
            {
                list = db.Orders.Include("Bills.Product").Where(a => a.Status == true && a.IsDelivered == true && a.UserId == user.Id)
                    .OrderByDescending(a => a.OrderDate).ToList();
            }
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return View(list);
        }

        [Authorize(Roles = "admin, manager")]
        public ActionResult OrderConfirm(int? type)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            if (user == null)
            {
                ViewBag.Message = "Vui lòng đăng nhập!";
                return View("Error");
            }
            List<Order> list = new List<Order>();
            if (type == null)
            {
                list = db.Orders.Include("Bills.Product").Include("User").Where(a => a.Status == true).OrderByDescending(a => a.OrderDate).ToList();
            }
            else if (type == 1) //1 = chưa giao
            {
                list = db.Orders.Include("Bills.Product").Include("User").Where(a => a.Status == true && a.IsDelivered == false).OrderByDescending(a => a.OrderDate).ToList();
            }
            else //còn lại = đã giao
            {
                list = db.Orders.Include("Bills.Product").Include("User").Where(a => a.Status == true && a.IsDelivered == true).OrderByDescending(a => a.OrderDate).ToList();
            }
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return View(list);
        }

        public ActionResult Comment(int orderId)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            if (user == null)
            {
                ViewBag.Message = "Vui lòng đăng nhập!";
                return View("Error");
            }
            List<Bill> list = db.Bills.Include(a => a.Product).Include("comment").Where(a => a.OrderId == orderId).ToList();
            if (list == null)
            {
                ViewBag.Message = "Oops, something happened";
                return View("Error");
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult SendComment(int billId, string strUrl, string comment)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            if (user == null)
            {
                ViewBag.Message = "Vui lòng đăng nhập!";
                return View("Error");
            }
            var bill = db.Bills.Find(billId);
            if (bill == null)
            {
                ViewBag.Message = "Cannot find bill!";
                return View("Error");
            }
            Comment cmt = new Comment();
            cmt.CommentId = billId;
            cmt.BillId = billId;
            cmt.CommentDate = DateTime.Now;
            cmt.UserComment = comment;
            cmt.Status = true;
            cmt.UserId = user.Id;
            db.Comments.Add(cmt);
            db.SaveChanges();
            return Redirect(strUrl);
        }
        
        public ActionResult DeleteOrder(int orderId, string str)
        {
            var order = db.Orders.Find(orderId);
            if (order == null)
            {
                ViewBag.Message = "Cannot find order!";
                return View("Error");
            }
            order.Status = false;
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect(str);
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