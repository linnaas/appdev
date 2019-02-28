using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LoginWeb.Models
{
    public class MessageLogin
    {
        public void wrongPass()
        {
            MessageBox.Show("Username or Password is invalid");
        }
        
    }
}