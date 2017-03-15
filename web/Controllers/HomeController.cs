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
        }
        // GET: Home
        public ActionResult Index()
        {
            
            AppUserManager.Create(new AppUser {
                NikeName="admin",
                UserName="admin",
            },"123456");
            return View();
        }
        public ActionResult Login(string username,string password)
        {
            
            return View();
        }
    }
}