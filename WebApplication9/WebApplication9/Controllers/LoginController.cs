using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Designer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Autherize(WebApplication9.Models.Designers designers)
        {
            using (eFashionPortalEntities3 db = new eFashionPortalEntities3())
            {
                var designerDetails = db.Designers.Where(x => x.DesignerEmail == designers.DesignerEmail && x.DesignerPassword == designers.DesignerPassword).FirstOrDefault();
                if (designerDetails==null)
                {
                    designers.LoginErrorMessage = "Wrong Input.";
                    return View("Designer",designers);
                }
                else
                {
                    Session["designerID"] = designerDetails.DesignerID;
                    Session["designerName"] = designerDetails.DesignerName;
                    Session["designerLastName"] = designerDetails.DesignerLastName;
                    Session["designerPhone"] = designerDetails.DesignerPhone;
                    Session["designerEmail"] = designerDetails.DesignerEmail;

                    return RedirectToAction("Board", "Home");
                }
            }
        }
    }
}