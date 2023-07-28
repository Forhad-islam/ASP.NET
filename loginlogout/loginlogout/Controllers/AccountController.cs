using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginlogout.Models;
using System.Web.Security;

namespace loginlogout.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Membeship model)
        {
            using (var context = new PRODUCTEntities())
            {
                bool isValid = context.Regi.Any(x=>x.UserName == model.UserName && x.Password == model.Password);
                if(isValid)
                {

                    FormsAuthentication.SetAuthCookie(model.UserName,false);
                    return RedirectToAction("Index","PRODUCT_TABLE");

                }
                ModelState.AddModelError("", "Invalid UserName and Password");
                    return View();
            }
               
        }

        //for singUP
        public ActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SingUp(Regi m)
        {
            using (var context = new PRODUCTEntities())
            {
                context.Regi.Add(m);
                context.SaveChanges();
            }
                return RedirectToAction("Login");
        }

        //Logout 
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }
    }
}