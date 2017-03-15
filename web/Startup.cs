using data;
using data.Infrastructure;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(web.Startup))]
namespace web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IdentityContext identity=new IdentityContext();
            app.CreatePerOwinContext(() => DependencyResolver.Current.GetService<AppUserManager>());
            //ConfigureAuth(app);
            using (var db=new IdentityContext() )
            {
                //new UserManager<AppUser>().Create(new AppUser { });
            }
        }
    }
}
