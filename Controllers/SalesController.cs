using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MicroWaveFood.Models;

namespace MicroWaveFood.Controllers
{
    [Authorize(Roles = "admin")]
    public class SalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sales
        public ActionResult Index()
        {
            return View(db.Sales.ToList());
        }

        [HttpPost]
        public ActionResult AddToSale(int productId, int saleId, string url)
        {
            
            try
            {
                var product = db.Products.Find(productId);
                var sale = db.Sales.Find(saleId);
                if (product == null || sale == null)
                {
                    ViewBag.Message = "Error";
                    return View("Error");
                }
                product.SaleId = sale.SaleId;
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return Redirect(url);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        // GET: Sales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Include("Products").FirstOrDefault(a => a.SaleId == id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.productId = new SelectList(db.Products.Where(a => a.status == true), "ProductId", "ProductName");
            return View(sale);
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SaleId,SaleName,SaleRate,From,To,SaleContent")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                if (sale.From > sale.To)
                {
                    ModelState.AddModelError("To", "From date must be smaller than To date");
                    return View(sale);
                }
                db.Sales.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sale);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SaleId,SaleName,SaleRate,From,To,SaleContent")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sale);
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sale sale = db.Sales.FirstOrDefault(a => a.SaleId == id);
            foreach (var item in db.Products.Where(a => a.status == true && a.SaleId == id).ToList())
            {
                item.SaleId = null;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }

            db.Sales.Remove(sale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSale(int productId, string url)
        {
            var product = db.Products.Find(productId);
            if (product == null)
            {
                ViewBag.Message = "Error";
                return View("Error");
            }
            product.SaleId = null;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect(url);
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
