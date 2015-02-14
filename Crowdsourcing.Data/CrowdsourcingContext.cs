using Crowdsourcing.Data.Configurations;
using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crowdsourcing.Data
{
    /*
 * this class  is responsible for three tasks which they are:
 * 1-Exposing our POCO classes as public  DbSet properties, this means that  every POCO class is transferred  to a database table.
 * 2-Overriding OnModelCreating procedure which is used to apply custom mapping rules for each POCO class by adding the new configurations to the DbModelBuilder configurations
 * 3-In this class constructor we have implemented two things:
 *   a-Disabled the ProxyCreationEnabled and LazyLoadingEnabled properties which they are enabled by default. The Lazy Loading property enables loading the sub-objects of model up front, in our case we want to load them on demand. The Proxy Creation property is used in conjugation with Lazy Loading property, so if is set to false the “LearningContext” won’t load sub-objects unless Include method is called.
     b-Configured the initialization and migration strategy of the database to migrate to latest
 *  version if a model has changed (i.e. new property has been added). To implement this we need to add
 *  new class called “LearningContextMigrationConfiguration” which derives from class
 *  “System.Data.Entity.Migrations.DbMigrationsConfiguration<TContext>”
 *  */
    public class CrowdsourcingContext : DbContext
    {
        public CrowdsourcingContext() :
            base("CrowdsourcingDB")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CrowdsourcingContext,
            //  Configuration>());
        }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TemplateConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }

}
