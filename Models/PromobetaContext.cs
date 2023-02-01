using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    public class PromobetaContext: DbContext
    {
        public PromobetaContext() : base("Promobeta")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Company> Company { get; set;  }
        public DbSet<CompanyUnits> CompanyUnits { get; set; }
        public DbSet<UnitStatus> UnitStatus { get; set; }
        public DbSet<UnitPromotions> UnitPromotions { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }        
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}