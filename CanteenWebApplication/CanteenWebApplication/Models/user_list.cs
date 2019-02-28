//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CanteenWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_list()
        {
            this.order_list = new HashSet<order_list>();
            this.employees = new HashSet<employee>();
            this.foods = new HashSet<food>();
        }
    
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = @"New Password")]
        public string newPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = @"Confirm New Password")]
        [Compare("newPassword", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string confirmPassword { get; set; }


        //[Display(Name = @"Enter new Email")]
        //public string newEmail { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = @"Old password")]
        public string oldPassword { get; set; }






        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_list> order_list { get; set; }
        public virtual administrator administrator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<food> foods { get; set; }
    }

    public class EditProfilePassword
    {

        [DataType(DataType.Password)]
        [Display(Name = @"New Password")]
        public string newPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = @"Confirm New Password")]
        [Compare("newPassword", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string confirmPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = @"Old password")]
        public string oldPassword { get; set; }

    }

    public class CompoundModel
    {
        public user_list user { get; set; }
        public EditProfilePassword editPassword { get; set; }

    }
}
