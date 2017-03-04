using data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace data
{
    public class IdentityContext:IdentityDbContext<AppUser>
    {
        public IdentityContext() : base("IdentityDb") { }
        static IdentityContext()
        {
            Database.SetInitializer(new Init());
        }
        public class Init : DropCreateDatabaseIfModelChanges<IdentityContext> {
            protected override void Seed(IdentityContext context)
            {
                base.Seed(context);
            }
        }
    }
}
