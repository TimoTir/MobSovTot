﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobSovAlytalo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MobSovAlytaloEntities : DbContext
    {
        public MobSovAlytaloEntities()
            : base("name=MobSovAlytaloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lampo> Lampo { get; set; }
        public virtual DbSet<Sauna> Sauna { get; set; }
        public virtual DbSet<Talo> Talo { get; set; }
        public virtual DbSet<Valo> Valo { get; set; }
        public virtual DbSet<Ilmastointi> Ilmastointi { get; set; }
    }
}