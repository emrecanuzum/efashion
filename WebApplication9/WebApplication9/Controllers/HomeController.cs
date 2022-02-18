using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;


namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {

       eFashionPortalEntities3 db = new eFashionPortalEntities3();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Board()
        {
            return View();
        }
        public ActionResult List()
        {
            var degerler = db.UpperBodyOutfit.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Your shop page.";

            return View();
        }
        public ActionResult WomanProducts()
        {
            ViewBag.Message = "Your woman products page.";

            return View();
        }
        public ActionResult ManProducts()
        {
            ViewBag.Message = "Your man products page.";

            return View();
        }

    }
}