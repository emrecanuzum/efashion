﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eFashionPortalEntities3 : DbContext
    {
        public eFashionPortalEntities3()
            : base("name=eFashionPortalEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accessory> Accessory { get; set; }
        public DbSet<Designers> Designers { get; set; }
        public DbSet<FashionShow> FashionShow { get; set; }
        public DbSet<LowerBodyOutfit> LowerBodyOutfit { get; set; }
        public DbSet<Models> Models { get; set; }
        public DbSet<ShoeProperties> ShoeProperties { get; set; }
        public DbSet<UpperBodyOutfit> UpperBodyOutfit { get; set; }
        public DbSet<Outfit> Outfit { get; set; }
        public DbSet<TechnicalDetail> TechnicalDetail { get; set; }
    }
}