using data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace data
{
    public class IdentityContext : IdentityDbContext<AppUser>
    {
        public IdentityContext() : base("IdentityDb") { }
        static IdentityContext()
        {
            Database.SetInitializer(new Init());
        }
        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public class Init : DropCreateDatabaseIfModelChanges<IdentityContext>
        {
            protected override void Seed(IdentityContext context)
            {
                PerformInitialSetup(context);
                base.Seed(context);
            }
            public void PerformInitialSetup(IdentityContext context)
            {
                context.Roles.Add(new IdentityRole { Name = "admin", Id = Guid.NewGuid().ToString() });
                context.SaveChanges();
            }
        }
    }
}
