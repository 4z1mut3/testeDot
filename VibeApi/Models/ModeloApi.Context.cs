﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibeApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProvaVibe_00Entities : DbContext
    {
        public ProvaVibe_00Entities()
            : base("name=ProvaVibe_00Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APOLICE> APOLICE { get; set; }
        public virtual DbSet<FINANCEIROAPOLICE> FINANCEIROAPOLICE { get; set; }
        public virtual DbSet<SEGURADO> SEGURADO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPOSEGURO> TIPOSEGURO { get; set; }
    }
}
