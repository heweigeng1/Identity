using data;
using data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(web.Startup))]
namespace web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IdentityContext identity=new IdentityContext();
            //ConfigureAuth(app);
            using (var db=new IdentityContext() )
            {
                //new UserManager<AppUser>().Create(new AppUser { });
            }
        }
    }
}
