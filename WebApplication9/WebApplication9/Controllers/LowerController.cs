using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class LowerController : Controller
    {
        eFashionPortalEntities3 db = new eFashionPortalEntities3();
        // GET: Lower
        public ActionResult LowerList(string p)
        {

            var y = from d in db.LowerBodyOutfit select d;
            if (!string.IsNullOrEmpty(p))
            {
                y = y.Where(m => m.Type.Contains(p));
            }
            return View(y.ToList());

            //var y = db.LowerBodyOutfit.ToList();
            //return View(y);
        }

        [HttpGet]
        public ActionResult NewLowerProduct()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NewLowerProduct(LowerBodyOutfit p1)
        {
            db.LowerBodyOutfit.Add(p1);
            db.SaveChanges();
            return View();
        }


        public ActionResult DeleteLowerProduct(int id)
        {
            var x = db.LowerBodyOutfit.Find(id);
            db.LowerBodyOutfit.Remove(x);
            db.SaveChanges();
            return RedirectToAction("LowerList");
        }


        public ActionResult UpdateLowerProduct(int id)
        {
            var x = db.LowerBodyOutfit.Find(id);
            return View("UpdateLowerProduct", x);
        }
        public ActionResult UpdateLower(LowerBodyOutfit p1)
        {
            var y = db.LowerBodyOutfit.Find(p1.LowerBodyID);
            y.LowerBodyID = p1.LowerBodyID;
            y.Type = p1.Type;
            y.Size = p1.Size;
            y.Color = p1.Color;
            y.Sex = p1.Sex;
            db.SaveChanges();
            return RedirectToAction("LowerList");
        }
    }
}