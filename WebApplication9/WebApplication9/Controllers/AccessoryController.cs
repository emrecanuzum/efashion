using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class AccessoryController : Controller
    {

        eFashionPortalEntities3 db = new eFashionPortalEntities3();

        public ActionResult Accessorys(string p)
        {

            var y = from d in db.Accessory select d;
            if (!string.IsNullOrEmpty(p))
            {
                y = y.Where(m => m.AccessoryName.Contains(p));
            }
            return View(y.ToList());

            //var z = db.Accessory.ToList();
            //return View(z);
        }



        [HttpGet]
        public ActionResult NewAccessoryProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAccessoryProduct(Accessory p1)
        {
            db.Accessory.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteAccessoryProduct(int id)
        {
            var x = db.Accessory.Find(id);
            db.Accessory.Remove(x);
            db.SaveChanges();
            return RedirectToAction("Accessorys");
        }
        public ActionResult UpdateAccessoryProduct(int id)
        {
            var x = db.Accessory.Find(id);
            return View("UpdateAccessoryProduct", x);
        }
        public ActionResult UpdateAccessory(Accessory p1)
        {
            var y = db.Accessory.Find(p1.AccessoryID);
            y.AccessoryID = p1.AccessoryID;
            y.CombineID = p1.CombineID;
            y.AccessoryName = p1.AccessoryName;
            y.AccessoryType = p1.AccessoryType;
            y.Color = p1.Color;
            y.Sex = p1.Sex;
            db.SaveChanges();
            return RedirectToAction("Accessorys");
        }
    }
}