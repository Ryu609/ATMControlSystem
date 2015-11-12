using ATMControlSystem.Lists;
using ATMControlSystem.Models;
using ATMControlSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ATMControlSystem.Controllers
{
    public class AccountController : Controller
    {
        private static int count = 1;

        // GET: Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        

        //POST: Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            
            //Verifies modelstate
            if (!ModelState.IsValid) return View(model);

            //Verifies if card is reported
            if (LoginUtils.IsCardReported(model.AccNumber) == true) return View("ReportedCard");
            
            var Cardholder = new CardHolder();

            if (Cardholder.List.Any(u => u.AccNumber == model.AccNumber && u.Password == model.Password) && count <= 3)
            {
                Session["AccNumber"] = model.AccNumber;
                Session.Timeout = 10;
                return RedirectToAction("Index","Home");               
            }       
            //number of login trials after failure is limited to 3 
                if (count >= 3) return View("LoginFail");

                count++;
                return View();          

        }
    }
}