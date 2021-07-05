using MicroWaveFood.Dtos;
using MicroWaveFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroWaveFood.Controllers.Api
{
    [Authorize(Roles = "admin")]
    public class OrderController : ApiController
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        [HttpPost]
        public IHttpActionResult OrderConfirm(OrderDto order)
        {
            if (order == null)
            {
                return BadRequest();
            }
            var confirmOrder = db.Orders.Find(order.OrderId);
            if (confirmOrder == null)
            {
                return BadRequest();
            }
            confirmOrder.IsDelivered = true;
            db.Entry(confirmOrder).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }
    }
}
