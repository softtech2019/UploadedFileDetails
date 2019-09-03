using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPDowload.ModelData;

namespace UPDowload.Controllers
{
    public class RegisterController : Controller
    {

        updownloadEntitiesModel db = new updownloadEntitiesModel();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(SiteUser model)
        {
            db.SiteUsers.Add(model);
            db.SaveChanges();
            return Json("Registeration Successfull", JsonRequestBehavior.AllowGet);

        }
    }
}