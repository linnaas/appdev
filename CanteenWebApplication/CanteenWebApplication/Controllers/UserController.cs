using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanteenWebApplication;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace CanteenWebApplication.Controllers
{
    public class UserController : Controller
    {
        private bool validInput = true;

        // Gathers current user account data, and returns it as view to Profile.cshtml
        [HttpGet]
        public ActionResult Profile()
        {
            var account = new User() { tempUsername = "jola", tempFirstName = "John", tempLastName = "Larsen", tempPassword = "12356zxz", tempEmail = "test@email.com", tempPhoneNumber = "91728536" };

            return View(account); 
        }

        // Defines actions taken as a result of attempted FirstName and/or LastName change
        [HttpPost]
        public ActionResult Profile(string FirstName, string LastName, string Password, string Password2, string Email, string PhoneNum, string PasswordConf)
        {
            Regex regexItem1 = new Regex("^[a-zA-Z- ]*$");

            object tempPassword = "123456zxz";
            object tempFirstName = "John";
            object tempLastName = "Lar";

            if (!String.IsNullOrEmpty(FirstName) || !String.IsNullOrEmpty(LastName))
            {
                if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PasswordConf))
                {
                    validInput = false;
                    return Content("dumbass empty name");
                }

                if (!PasswordConf.Equals(tempPassword))
                {
                    validInput = false;
                    return Content("dumbass password name");
                }

                if (!regexItem1.IsMatch(FirstName) || !regexItem1.IsMatch(LastName))
                {
                    validInput = false;
                    return Content("dumbass symbols name");
                }

                else if (validInput)
                {
                    return Content($"Hello {FirstName} {LastName} you were called {tempFirstName} {tempLastName} {PasswordConf} {tempPassword}");
                }

            }

            if (!String.IsNullOrEmpty(Password) || !String.IsNullOrEmpty(Password2))
            {
                if (String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(Password2) || String.IsNullOrEmpty(PasswordConf))
                {
                    validInput = false;
                    return Content("dumbass empty password");
                }

                if (!Password.Equals(Password2))
                {
                    validInput = false;
                    return Content("dumbass identical password");
                }

                if (!PasswordConf.Equals(tempPassword))
                {
                    validInput = false;
                    return Content("dumbass password password");
                }

                else if (validInput)
                {
                    return Content($"Password {tempPassword} has been changed to {Password}");
                }

            }

            if (!String.IsNullOrEmpty(Email))
            {

                if(String.IsNullOrEmpty(Email))
                {
                    validInput = false;
                    return Content("dumbass empty email");
                }

                if (!PasswordConf.Equals(tempPassword))
                {
                    validInput = false;
                    return Content("dumbass password password");
                }

                //bool IsValidEmail(string email)
                //{
                //    try
                //    {
                //        var addr = new System.Net.Mail.MailAddress(email);
                //        return addr.Address == email;
                //    }
                //    catch
                //    {
                //        return false;
                //    }
                //} 

                
                else if (validInput)
                {
                    return Content($"ny email er {Email}");
                }

            }

            if (!String.IsNullOrEmpty(PhoneNum))
            {
                if(String.IsNullOrEmpty(PhoneNum))
                {
                    validInput = false;
                    return Content("dumbass empty phone");
                }

                else if(validInput)
                {
                    return Content($"new phone {PhoneNum}");
                }
            }

            return Content("No input");
            

        }

        //// Defines actions taken as a result of attempted Username change ( CURRENTLY NOT AVAILABLE ) 
        //public ActionResult Profile(string Username, string PasswordConf)
        //{
        //    Regex regexItem = new Regex("^[a-zA-Z-]*$");

        //    object tempPassword = "123456zxz";
        //    object tempUsername = "jola";
        //    object otherUsername = "haha"

        //    if(String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(PasswordConf))
        //    {
        //        validInput = false;
        //        return Content("dumbass empty username");
        //    }

        //    if (Username.Equals(otherUsername))
        //    {
        //        validInput = false;
        //        return Content = 
        //    }

        //    if(!PasswordConf.Equals(tempPassword))
        //    {
        //        validInput = false;
        //        return Content("dumbass password username");
        //    }

        //}

        // Defines actions taken as a result of attempted Password change. Requires two identical Password inputs, in addition to password confiramtion
        [HttpPost]
        public ActionResult Profile2(string Password, string Password2, string PasswordConf)
        {
            Regex regexItem = new Regex("^[a-zA-Z-]*$");
            object tempPassword = "123456zxz";



            return null;
        }

        // Defines actions taken as a result of attempted Email change
        [HttpPost]
        public ActionResult Profile3(string Email, string PasswordConf)
        {
            Regex regexItem = new Regex("^[a-zA-Z-]*$");
            object tempPassword = "123456zxz";
            object tempEmail = "temp@email.com";

            return null;
        }

        // Defines actions taken as a result of attempted PhoneNum change. Password confirmation unnecessary
        [HttpPost]
        public ActionResult Profile4(string PhoneNum)
        {
            Regex regexItem = new Regex("^[a-zA-Z-]*$");
            object tempPassword = "123456zxz";

            return null;

        }
    }
}