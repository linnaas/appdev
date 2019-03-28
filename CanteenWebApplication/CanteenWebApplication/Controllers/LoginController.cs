using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanteenWebApplication.Models;

namespace CanteenWebApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autorize(CanteenWebApplication.Models.user_list userModel)
        {
            using (CanteenDBContext db = new CanteenDBContext())
            {
                var userDetails = db.Users.Where(x => x.username == userModel.username && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "The username or password is incorrect";
                    return View("Login", userModel);
                }
                else
                {
                    Session["username"] = userDetails.username;
                    return RedirectToAction("Midlertidig", "Midlertidig");
                }
            }


        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}



