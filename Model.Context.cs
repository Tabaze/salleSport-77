﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace salleSport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestionSalleSprortEntities : DbContext
    {
        public gestionSalleSprortEntities()
            : base("name=gestionSalleSprortEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adherent> Adherent { get; set; }
        public virtual DbSet<benifice> benifice { get; set; }
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<t_function> t_function { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
    }
}