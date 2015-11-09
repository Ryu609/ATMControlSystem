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

            if (WithdrawUtils.CheckBalance(accNum, amount).Equals(true))
            {
                int thousand = 0, fiveHundred = 0, twoHundred = 0, hundred = 0, fifty = 0, twenty = 0;

                if (amount >= 1000)
                {
                    thousand = amount / 1000;
                    amount %= 1000;
                }
                if (amount >= 500 && amount < 1000)
                {
                    fiveHundred = amount / 500;
                    amount %= 500;
                }

                if (amount >= 200 && amount < 500)
                {
                    twoHundred = amount / 200;
                    amount %= 200;
                }

                if (amount >= 100 && amount < 200)
                {
                    hundred = amount / 100;
                    amount %= 100;
                }

                if (amount >= 50 && amount < 100)
                {
                    fifty = amount / 50;
                    amount %= 50;
                }

                if (amount >= 20 && amount < 50)
                {
                    twenty = amount / 20;
                    amount %= 20;
                }

                WithdrawUtils.Dispense(thousand, fiveHundred, twoHundred, hundred, fifty,twenty,accNum, accNum);                

            }

            return View();      
        }
    }
}