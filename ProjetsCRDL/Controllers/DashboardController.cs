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
        //POUR LOGIN 
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(utilisateur user)
        {
            var v = from p in db.profiles
                    join u in db.utilisateurs
                        on p.ID_profile equals u.ID_profile
                    where (u.username == user.username && u.passwords == user.passwords)
                    select new
                    {
                        profile_name = p.NOM_profile,
                        username = u.username,
                        employeStation = u.ID_employ,
                        passord=u.passwords,
                        employeAssociation = u.ID_employe,
                        a=u.ID_profile
                    };

            var result = v.FirstOrDefault();
            if (result != null)
            {
                Session["username"] = result.username;
                Session["profile"] = result.profile_name;
                Session["IDEmploye"] = result.employeAssociation;
                Session["IDEmploy"] = result.employeStation;
                Session["association"] = "";
                ;
                if (result.profile_name == "Admin")
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                if (result.profile_name == "employe")
                {
                  
                    return RedirectToAction("Dashboard", "ClientStation");
                }
            }

            return View(user);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}