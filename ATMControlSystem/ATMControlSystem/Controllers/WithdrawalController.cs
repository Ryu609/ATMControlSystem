using ATMControlSystem.Lists;
using ATMControlSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMControlSystem.Controllers
{
    [Authorize]
    public class WithdrawalController : Controller
    {
        public ActionResult Withdraw()
        {
            
            return View();
        }

        public ActionResult Withdraw(int accNum, int amount)
        {
            //Verifies if Balance has sufficient fund
            if (WithdrawUtils.CheckBalance(accNum, amount).Equals(true))
            {               
                //Calls the dispense method
                WithdrawUtils.Dispense(accNum,amount);              

            }

            return View();      
        }
    }
}