using MicroWaveFood.Dtos;
using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroWaveFood.Controllers.Api
{
    public class CartController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(ProductDto product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            List<Cart> list = TakeCart();
            //check if this product is in session["cart"]
            Cart cart = list.Find(a => a.ProductId == product.ProductId);
            if (cart == null)
            {
                cart = new Cart(product.ProductId);
                list.Add(cart);
            }
            else
            {
                cart.Amount++;
            }

            return Ok();
        }
        private List<Cart> TakeCart()
        {
            //List<Cart> listCart = Session["Cart"] as List<Cart>;
            List<Cart> listCart = ListCart.Carts;
            if (listCart == null)
            {
                //if list cart doesn't exist, create one
                listCart = new List<Cart>();
                //Session["Cart"] = listCart;
                ListCart.Carts = listCart;
            }
            return listCart;
        }


    }
}
