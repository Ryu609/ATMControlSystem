using ATMControlSystem.Lists;
using ATMControlSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ATMControlSystem.Controllers
{
   // [Authorize]
    public class WithdrawalController : Controller
    {
        public ActionResult Withdraw()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Withdraw(int accNum, int amount)
        {

            //Verifies if Balance has sufficient fund && Calls the dispense method
            if (WithdrawUtils.CheckBalance(accNum, amount) && WithdrawUtils.Dispense(accNum, amount))
            {
                return View();                
            }
             return RedirectToAction("InsufficientFund");
            
        }

        //Action called if Account has insufficient fund
        public ActionResult InsufficientFund()
        {
            return View();
        }

       
    }
}