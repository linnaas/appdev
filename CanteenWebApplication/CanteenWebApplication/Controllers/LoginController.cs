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
        public ActionResult LoginAction(CanteenWebApplication.Models.user_list users)
        {
            using (CanteenDBContext database = new CanteenDBContext())
            {
                var userDetails = database.Users.Where(x => x.username == users.username && x.password == users.password).FirstOrDefault();
                if (userDetails == null)
                {
                    users.LoginError = "The username or password is incorrect";
                    return View("Login", users);
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


