using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanteenWebApplication.Models;

namespace CanteenWebApplication.Controllers
{
    public class UserController : Controller
    {



        // Gets information about current user-session, and returns it to View (UserProfile.cshtml)
        public ActionResult UserProfile()
        {
            var UserSession = Session["username"] ;

            using (var context = new CanteenDBContext())
            {
                var userInfo = context.Users.Where(u => u.username == UserSession).FirstOrDefault<user_list>();

                return View(userInfo);
                
            }
            
        }
        
        // Based on which submit-button has been pressed in a modal, a specfic algorythm is launched and executed. user_list "user" carries new information, while userEdit carries old information.
        [HttpPost]
        public ActionResult UserProfile(user_list user, string submit)
        {

            var UserSession = Session["username"];

            if (submit == "Save new password") // If the submit-button for saving password is pressed
            {

                if (ModelState.IsValid)
                {
                    using (var context = new CanteenDBContext())
                    {
                        var userEdit = context.Users.Where(x => x.username == UserSession).FirstOrDefault<user_list>();
                    
                        if (user.oldPassword == userEdit.password)
                        {

                            if (userEdit != null)
                            {
                                userEdit.password = user.newPassword;
                                context.SaveChanges();

                                string test3 = "password changed to" + user.newPassword;
                                return View(userEdit);
                            
                            }
                        }
                        string test = "old password incorrect";
                        return Content(test);
                    }
                }
                string test2 = "confirmation password not equal";
                return Content(test2);

            }

            if (submit == "Save new email")
            {
                if (ModelState.IsValid)
                {
                    using (var context = new CanteenDBContext())
                    {
                        var userEdit = context.Users.Where(x => x.username == UserSession).FirstOrDefault<user_list>();

                        if (user.oldPassword == userEdit.password)
                        {

                            if (userEdit != null)
                            {
                                userEdit.email = user.email;
                                context.SaveChanges();

                                string test3 = "email changed to" + user.email;
                                return View(userEdit);

                            }
                        }
                        string test = "old password incorrect";
                        return Content(test);
                    }
                }
                
            }

            if (submit == "Save new number")
            {
                if (ModelState.IsValid)
                {
                    using (var context = new CanteenDBContext())
                    {
                        var userEdit = context.Users.Where(x => x.username == UserSession).FirstOrDefault<user_list>();

                        if (user.oldPassword == userEdit.password)
                        {

                            if (userEdit != null)
                            {
                                userEdit.phone = user.phone;
                                context.SaveChanges();

                                string test3 = "phone changed to" + user.phone;
                                return View(userEdit);

                            }
                        }
                        string test = "old password incorrect";
                        return Content(test);
                    }
                }


            }
            return Content(submit);
        }




        // GET: User/Delete/5
        public ActionResult UserDelete()
        {

            var UserSession = Session["username"];

            using (var context = new CanteenDBContext())
            {
                
                var userRemove = context.Users.Where(x => x.username == UserSession).FirstOrDefault<user_list>();

                context.Users.Remove(userRemove);
                context.SaveChanges();

            }
            return null;
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
