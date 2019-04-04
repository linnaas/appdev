using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanteenWebApplication.Models;

namespace CanteenWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registration()
        {
            return View();
        }

        // GET: Registration/Details/5
        public ActionResult Details(user_list user)
        {

            //var UserSession = Session["username"];


            //if (ModelState.IsValid)
            //{
            //    using (var context = new CanteenDBContext())
            //    {
            //        var userEdit = context.Users.Where(x => x.username == UserSession).FirstOrDefault<user_list>();

            //        if (user.oldPassword == userEdit.password)
            //        {

            //            if (userEdit != null)
            //            {
            //                userEdit.password = user.newPassword;
            //                context.SaveChanges();

            //                string test3 = "password changed to" + user.newPassword;
            //                return View(userEdit);

            //            }
            //        }
            //        string test = "old password incorrect";
            //        return Content(test);
            //    }
            //}
            //string test2 = "confirmation password not equal";
            //return Content(test2);
            return View();

        }

     
    }
}
