using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
<<<<<<< HEAD
=======
using System.Security.Cryptography;
using System.Text;
>>>>>>> template
using System.Web;
using System.Web.Mvc;
using ProjetsCRDL.Models;

<<<<<<< HEAD
namespace ProjetsCRDL.Controllers
{
    public class DashboardController : Controller
    {
        private RecolteEntities1 db = new RecolteEntities1();
        //pour login
=======
namespace TEMPLATE.Controllers
{
    public class DashboardController : Controller
    {
        private RecolteEntities2 db = new RecolteEntities2();
        //POUR LOGIN 
>>>>>>> template
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
<<<<<<< HEAD
                        passord = u.passwords,
                        employeAssociation = u.ID_employe,
                        a = u.ID_profile
=======
                        passord=u.passwords,
                        employeAssociation = u.ID_employe,
                        a=u.ID_profile
>>>>>>> template
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
<<<<<<< HEAD
                ///Session["IDEmploye"] = result.employeAssociation;
                //    Session["IDEmploy"] = result.employeStation;
                //    return RedirectToAction("Index", "Dashboard");

=======
                   ///Session["IDEmploye"] = result.employeAssociation;
                //    Session["IDEmploy"] = result.employeStation;
                //    return RedirectToAction("Index", "Dashboard");
                    
>>>>>>> template
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
<<<<<<< HEAD

=======
                               
>>>>>>> template
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