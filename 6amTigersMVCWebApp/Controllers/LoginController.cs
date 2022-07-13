﻿using _6amTigersMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _6amTigersMVCWebApp.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            EmployeeEntities db = new EmployeeEntities();
            UserDetail uinfo = db.UserDetails.Where(u => u.UserName == user.UserName && u.Password == user.Password).SingleOrDefault();
            if (uinfo != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect("SecuredPage");
            }
            return View();
        }

        // GET: Login
        [Authorize]
        public ActionResult SecuredPage()
        {
            return View();
        }



        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("login");
        }
    }
}