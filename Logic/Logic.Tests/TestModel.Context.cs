﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace s2.s2Utils.Logic.Tests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    [GeneratedCode("Entity Framework", "6.1.3")]
    [DbConfigurationType(typeof(s2Utils.Logic.Utils.Misc.SqlAzureDatabaseConfiguration))] 
    public partial class TestDbEntities : DbContext
    {
    
    	internal TestDbEntities(string connectionStringName)
                : base("name=" + connectionStringName)
        {
    	}
    
        internal TestDbEntities()
            : base("name=TestDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Person> People { get; set; }
    }
}