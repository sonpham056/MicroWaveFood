using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using MicroWaveFood.Models;
using MicroWaveFood.ViewModels;
using PagedList;

namespace MicroWaveFood.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var products = db.Products.Where(a => a.status == true && a.ProductType.Status == true).Include(p => p.ProductType);
            return View(products.ToList().ToPagedList(pageNumber, pageSize));
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product.status == false)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.ProductTypeId = new SelectList(db.productTypes.Where(a => a.Status == true), "ProductTypeId", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductTypeId,ProductName,ProductDescribe,Price,Unit,Date,Image,Quantity,status,Origin")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.status = true;
                product.Image = "/Images/" + product.Image;
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductTypeId = new SelectList(db.productTypes, "ProductTypeId", "Name", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product.status == false)
            {
                return HttpNotFound();
            }
            ViewBag.ProductTypeId = new SelectList(db.productTypes, "ProductTypeId", "Name", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductTypeId,ProductName,ProductDescribe,Price,Unit,Date,Image,Quantity,Origin")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.status = true;
                product.Image = "/Images/" + product.Image;
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductTypeId = new SelectList(db.productTypes, "ProductTypeId", "Name", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product.status == false)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            product.status = false;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public ActionResult ProductDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Include(p => p.ProductType)
                .Include("Bills.Comment.User")
                .FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product.status == false)
            {
                return HttpNotFound();
            }
            ProductViewModel productViewModel = new ProductViewModel
            {
                Product = product,
                RelatedProducts = db.Products.Where(p => p.ProductTypeId == product.ProductTypeId && p.status == true).ToList()
            };
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            return View(productViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
        
        
        //==-----------'
        [AllowAnonymous]
        public ActionResult Search(string str)
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            var products = db.Products
                .ToList()
                .Where(a => a.ProductName.ToLower().Contains(str.ToLower()) && a.status == true)
                .ToList();
            return View("ListProduct", products);
        }

        [AllowAnonymous]
        public ActionResult ListProduct(string str)
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            var products = db.Products.Include("ProductType").ToList().Where(a => a.ProductType.GroupType.ToLower().Contains(str.ToLower()) && a.status == true).ToList();
            return View(products);
        }
        [AllowAnonymous]
        public ActionResult ListSale(string str)
        {
            var products = db.Products.Where(a => a.SaleId != null && a.status == true).ToList();
            return View(products);
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

        private static string ConvertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        [AllowAnonymous]
        public ActionResult ProductsInProductType(int id)
        {
            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            var products = db.Products.Include("ProductType").Where(a => a.ProductType.ProductTypeId == id && a.status == true).ToList();
            return View("ListProduct", products);
        }
    }
}
