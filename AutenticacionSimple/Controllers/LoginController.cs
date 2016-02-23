﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using AutenticacionSimple.Models;

namespace AutenticacionSimple.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Usuario model)
        {
            //var esta = HttpContext.User.Identity;

            if (model.Login == model.Password)
            {
                var iden = new GenericIdentity(model.Login);
                var prin = new GenericPrincipal(iden,new []{"Admin"});



                Thread.CurrentPrincipal = prin;
                FormsAuthentication.SetAuthCookie(model.Login,false);
                return RedirectToAction("Index", "Home");

            }

            ModelState.AddModelError("Err",
            "Autenticacion incorrecta");
            return View(model);
        }


    }
}