﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CanteenDBContext : DbContext
    {
        public CanteenDBContext()
            : base("name=CanteenDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> Categories { get; set; }
        public virtual DbSet<food> Foods { get; set; }
        public virtual DbSet<image> Images { get; set; }
        public virtual DbSet<order_detail> Order_details { get; set; }
        public virtual DbSet<order_list> Orders { get; set; }
        public virtual DbSet<user_list> Users { get; set; }
        public virtual DbSet<administrator> Administrators { get; set; }
        public virtual DbSet<employee> Employees { get; set; }
        public virtual DbSet<food_availability> Food_availabilities { get; set; }
        public virtual DbSet<EditProfilePassword> EditProfileModels { get; set; }
    }
}