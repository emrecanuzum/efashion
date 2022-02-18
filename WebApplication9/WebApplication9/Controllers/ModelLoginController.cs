using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ModelLoginController : Controller
    {
        // GET: ModelLogin
        public ActionResult ModelLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(WebApplication9.Models.Models models)
        {
            using (eFashionPortalEntities3 db = new eFashionPortalEntities3())
            {
                var modelDetails = db.Models.Where(x => x.ModelEmail == models.ModelEmail && x.ModelPassword == models.ModelPassword).FirstOrDefault();
                if (modelDetails == null)
                {
                    models.LoginErrorMessage = "Wrong Input.";
                    return View("ModelLogin", models);
                }
                else
                {
                    Session["designerID"] = modelDetails.ModelID;
                    Session["designerName"] = modelDetails.ModelName;
                    Session["designerLastName"] = modelDetails.ModelLastName;
                    Session["designerPhone"] = modelDetails.ModelPhone;
                    Session["designerEmail"] = modelDetails.ModelEmail;

                    return RedirectToAction("List", "List");
                }
            }
        } 
        }
    }