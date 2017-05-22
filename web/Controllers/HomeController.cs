using data;
using data.Infrastructure;
using data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
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
        private  AppUserManager appUserManager { get { return Request.GetOwinContext().GetUserManager<AppUserManager>(); } }
        public HomeController()
        {
        }
        // GET: Home
        public ActionResult Index()
        {
            var context = appUserManager;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
          var user=  appUserManager.Find(username, password);
            return Json(user,JsonRequestBehavior.AllowGet);
        }
        public ActionResult reg(string username,string password)
        {
          var result=  appUserManager.Create(new AppUser
            {
                Email="123@123.com",
                NikeName="超管",
                PhoneNumber="1234567890",
                Id=Guid.NewGuid().ToString(),
                UserName= username
          },password);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}