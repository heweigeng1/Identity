using data;
using data.Infrastructure;
using data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private static AppUserManager AppUserManager;
        public HomeController()
        {
            AppUserManager = new AppUserManager(new UserStore<AppUser>(new IdentityContext()));
            AppUserManager.Create<AppUser, string>(new AppUser
            {
                Email = "123@123.com",
                Id=Guid.NewGuid().ToString(),
                NikeName="admin",
                PhoneNumber="123123",
                UserName="admin",
            }, "testadmin");
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string username, string password)
        {

            return View();
        }
    }
}