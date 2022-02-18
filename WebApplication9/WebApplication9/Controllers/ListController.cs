using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ListController : Controller
    {

        eFashionPortalEntities3 db = new eFashionPortalEntities3();
        //eFashionPortalEntities db = new eFashionPortalEntities();

        // GET: List
        public ActionResult List()
        {
            return View();
        }
        
        public ActionResult UpperList(string p)

        {
            var y = from d in db.UpperBodyOutfit select d;
            if (!string.IsNullOrEmpty(p))
            {
                y = y.Where(m => m.Type.Contains(p));
            }
            return View(y.ToList());


            //var x = db.UpperBodyOutfit.ToList();
            //return View(x);
        }

        
        [HttpGet]
        public ActionResult NewUpperProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUpperProduct(UpperBodyOutfit p1)
        {
            db.UpperBodyOutfit.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteUpperProduct(int id)
        {
            var x = db.UpperBodyOutfit.Find(id);
            db.UpperBodyOutfit.Remove(x);
            db.SaveChanges();
            return RedirectToAction("UpperList");
        }
        public ActionResult UpdateUpperProduct(int id)
        {
            var x = db.UpperBodyOutfit.Find(id);
            return View("UpdateUpperProduct", x);
        }
        public ActionResult UpdateUpper(UpperBodyOutfit p1)
        {
            var y = db.UpperBodyOutfit.Find(p1.UpperBodyID);
            y.UpperBodyID = p1.UpperBodyID;
            //y.Type = p1.Type;
            y.Size = p1.Size;
            y.Color = p1.Color;
            y.Sex=p1.Sex;
            db.SaveChanges();
            return RedirectToAction("UpperList");
        }
    }
}