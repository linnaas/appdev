
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CanteenWebApplication.Models;
using System.Dynamic;
using CanteenWebApplication.DAO;
using Microsoft.AspNetCore.Http;

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
        public ActionResult LoginAction(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.loginValidation(user.username, user.password))
                {
                    HttpContext.Session.SetString("userSession", user.username);
                    //Session["username"] = user.username;
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login", user);
                }
            }
            else
            {
                return View();
            }
            
            //using (CanteenDBContext database = new CanteenDBContext())
            //{
            //    var userDetails = database.User.Where(x => x.username == users.username && x.password == users.password).FirstOrDefault();
            //    if (userDetails == null)
            //    {
            //        User.LoginError = "The username or password is incorrect";
            //        return View("Login", users);
            //    }
            //    else
            //    {
            //        Session["username"] = userDetails.username;
            //        return RedirectToAction("Index", "Home");
            //    }
            //}
            
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            //Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}


