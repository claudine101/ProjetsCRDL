using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetsCRDL.Models;

namespace ProjetsCRDL.Controllers
{
    public class DashboardController : Controller
    {
        private RecolteEntities1 db = new RecolteEntities1();
        //pour login
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
                        passord = u.passwords,
                        employeAssociation = u.ID_employe,
                        a = u.ID_profile
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
                //if (result.profile_name == "employe")
                //{
                ///Session["IDEmploye"] = result.employeAssociation;
                //    Session["IDEmploy"] = result.employeStation;
                //    return RedirectToAction("Index", "Dashboard");

                //}
                if (result.profile_name == "Admin")
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                if (result.profile_name == "employe")
                {
                    // var aa=@Session["IDEmploy"];
                    // var IDS = from e in db.employe_station_lavage
                    //        join s in db.station_lavage
                    //            on e.ID_station equals s.ID_station
                    //          where (e.ID_employ == 2)
                    //        select new
                    //        {
                    //            station = s.ID_station,

                    //        };
                    // var resultE = IDS.FirstOrDefault();
                    //if (resultE != null)
                    //{
                    //    Session["station"] = resultE.station ;
                    //}
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