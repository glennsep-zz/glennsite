﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlennSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CaseFactSheetEntities : DbContext
    {
        public CaseFactSheetEntities()
            : base("name=CaseFactSheetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CFS_Alibi> CFS_Alibi { get; set; }
        public virtual DbSet<CFS_MurderFacts> CFS_MurderFacts { get; set; }
        public virtual DbSet<CFS_WhoDidIt> CFS_WhoDidIt { get; set; }
        public virtual DbSet<CFS_WhoWasWhere> CFS_WhoWasWhere { get; set; }
    }
}
