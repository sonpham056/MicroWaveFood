using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace MicroWaveFood.Controllers
{
    [Authorize(Roles = "admin, manager")]
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        // GET: Comments
        public ActionResult Index()
        {
            var list = db.Products.Include("Bills.Comment").Where(a => a.status == true ).ToList();
            return View(list);
        }

        public ActionResult Detail(int Id)
        {
            var product = db.Products.Include("Bills.Comment.User").Where(a => a.status == true).FirstOrDefault(a => a.ProductId == Id);
            if (product == null)
            {
                ViewBag.Message = "Product not found!";
                return View("error");
            }
            return View(product);
        }

        public ActionResult Delete(int Id, string strUrl)
        {
            var comment = db.Comments.FirstOrDefault(a => a.CommentId == Id);
            if (comment != null)
            {
                db.Comments.Remove(comment);
                db.SaveChanges();
            } 
            else
            {
                ViewBag.Messge = "Error when deleting comment";
                return View("error");
            }
            return Redirect(strUrl);
        }
    }
}