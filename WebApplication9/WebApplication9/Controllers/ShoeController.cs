using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{

    public class ShoeController : Controller
    {
        // GET: Shoe
        eFashionPortalEntities3 db = new eFashionPortalEntities3();
        public ActionResult Shoes(string p)
        {
            var y = from d in db.ShoeProperties select d;
            if (!string.IsNullOrEmpty(p))
            {
                y = y.Where(m => m.Type.Contains(p));
            }
            return View(y.ToList());

            //var t = db.ShoeProperties.ToList();
            //return View(t);
        }
        [HttpGet]
        public ActionResult NewShoeProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewShoeProduct(ShoeProperties p1)
        {
            db.ShoeProperties.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteShoeProduct(int id)
        {
            var x = db.ShoeProperties.Find(id);
            db.ShoeProperties.Remove(x);
            db.SaveChanges();
            return RedirectToAction("Shoes");
        }
        public ActionResult UpdateShoeProduct(int id)
        {
            var x = db.ShoeProperties.Find(id);
            return View("UpdateShoeProduct", x);
        }
        public ActionResult UpdateShoe(ShoeProperties p1)
        {
            var y = db.ShoeProperties.Find(p1.ShoeID);
            y.ShoeID = p1.ShoeID;        
            y.Type = p1.Type;
            y.Size = p1.Size;
            y.Color = p1.Color;
            y.Sex = p1.Sex;
            db.SaveChanges();
            return RedirectToAction("Shoes");
        }
    }
}