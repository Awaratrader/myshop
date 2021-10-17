using myshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myshop.Controllers
{
    
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult IndexCustomer()
        {
            return View();
        }
        public ActionResult IndexAdmin()
        {
            return View();
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

        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            // Count records from db admin table where email and password matched with out posted email password
            // If email and password is matched then result is 1, Else result would be zero
            int result = db.Admins.Where(x => x.ADMIN_EMAIL == a.ADMIN_EMAIL && x.ADMIN_PASSWORD == a.ADMIN_PASSWORD).Count();
            if (result==1)
            {
                return RedirectToAction("IndexAdmin", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Email or Password";
                return View();
            }
            return View();
        }


    }
}