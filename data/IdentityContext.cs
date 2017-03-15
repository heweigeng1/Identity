using data.Maping;
using data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace data
{
    public class IdentityContext : IdentityDbContext<AppUser>
    {
        public IdentityContext() : base("IdentityDb") { }
        static IdentityContext()
        {
            Database.SetInitializer<IdentityContext>(new DropCreateDatabaseAlways<IdentityContext>());
            
        }
        //public DbSet<UserClaim> UserClaims { get; set; }
        //public DbSet<AppUser> AppUsers { get; set; }
        //public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.Add(new AppUserMaping());
            //modelBuilder.Configurations.Add(new UserClaimMaping());
            // 移除复数表名公约
        }
        public class Init : CreateDatabaseIfNotExists<IdentityContext>
        {
            protected override void Seed(IdentityContext context)
            {
                context.Roles.Add(new IdentityRole { Name="admin",Id=Guid.NewGuid().ToString()});
                context.SaveChanges();
                base.Seed(context);
            }
            public void PerformInitialSetup(IdentityContext context)
            {
                // initial configuration will go here
                // 初始化配置将放在这儿
            }
        }
    }
}
