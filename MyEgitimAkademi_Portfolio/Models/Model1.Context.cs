﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyEgitimAkademi_Portfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyPortfolioDbEntities : DbContext
    {
        public MyPortfolioDbEntities()
            : base("name=MyPortfolioDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Testimonial> Testimonial { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AwardInfo> AwardInfo { get; set; }
        public virtual DbSet<Awards> Awards { get; set; }
        public virtual DbSet<ClientInfo> ClientInfo { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientStats> ClientStats { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<QuickContact> QuickContact { get; set; }
        public virtual DbSet<TestimonialInfo> TestimonialInfo { get; set; }
    }
}