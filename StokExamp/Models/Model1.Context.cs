﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokExamp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STOKEntities1 : DbContext
    {
        public STOKEntities1()
            : base("name=STOKEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_GirisCikis> tbl_GirisCikis { get; set; }
        public virtual DbSet<tbl_Musteri> tbl_Musteri { get; set; }
        public virtual DbSet<tbl_Urun> tbl_Urun { get; set; }
    }
}
