﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMDWebApplication.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbVervoerEntities : DbContext
    {
        public dbVervoerEntities()
            : base("name=dbVervoerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetCart> AspNetCarts { get; set; }
        public virtual DbSet<AspNetCartInsurance> AspNetCartInsurances { get; set; }
        public virtual DbSet<AspNetCartStatu> AspNetCartStatus { get; set; }
        public virtual DbSet<AspNetCategory> AspNetCategories { get; set; }
        public virtual DbSet<AspNetInsurance> AspNetInsurances { get; set; }
        public virtual DbSet<AspNetMessage> AspNetMessages { get; set; }
        public virtual DbSet<AspNetProduct> AspNetProducts { get; set; }
        public virtual DbSet<AspNetReply> AspNetReplies { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetShippingDetail> AspNetShippingDetails { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<DualDatabaseTestSchemeQuestion> DualDatabaseTestSchemeQuestions { get; set; }
        public virtual DbSet<DualDatabaseTestSchemeTest> DualDatabaseTestSchemeTests { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<InsuranceClaim> InsuranceClaims { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportPMD> ReportPMDs { get; set; }
        public virtual DbSet<SecurityConfiguration> SecurityConfigurations { get; set; }
    
        public virtual ObjectResult<GetBySearch_Result> GetBySearch(string search)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBySearch_Result>("GetBySearch", searchParameter);
        }
    
        public virtual ObjectResult<GetBySearchInsurance_Result> GetBySearchInsurance(string search)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBySearchInsurance_Result>("GetBySearchInsurance", searchParameter);
        }
    }
}
