﻿using MicroWaveFood.Models;
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
        private ApplicationDbContext db = new ApplicationDbContext();
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
        public ActionResult Index()
        {

            ViewBag.AmountSum = AmountSum();
            ViewBag.PriceSum = PriceSum();
            var HomeViewModel = new HomeIndexViewModel
            {
                ProductList = db.Products.Where(a => a.status == true).ToList()
            };
            return View(HomeViewModel);
        }

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