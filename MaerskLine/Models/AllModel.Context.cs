﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaerskLine.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MaerskLineEntities : DbContext
    {
        public MaerskLineEntities()
            : base("name=MaerskLineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
    }
}
