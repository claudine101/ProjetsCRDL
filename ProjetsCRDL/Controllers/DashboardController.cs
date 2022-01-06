using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ProjetsCRDL.Models;

namespace TEMPLATE.Controllers
{
    public class DashboardController : Controller
    {
        private RecolteEntities2 db = new RecolteEntities2();
        public ActionResult Login()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}