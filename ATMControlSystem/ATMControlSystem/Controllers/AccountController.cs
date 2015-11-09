using ATMControlSystem.Lists;
using ATMControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {

            if (!ModelState.IsValid) return View(model);


            var Cardholder = new CardHolder();

            if (Cardholder.List.Any(u => u.AccNumber == model.AccNumber && u.Password == model.Password) && count <= 3)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (count >= 3) return View("ForgotPassword");

                count++;
                return View();
            }


        }
    }
}