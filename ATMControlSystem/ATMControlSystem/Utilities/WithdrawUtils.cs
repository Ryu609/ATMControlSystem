using ATMControlSystem.Lists;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Utilities
{
    public static class WithdrawUtils
    {        
        //Verifies account balance
        public static bool CheckBalance(int accountNum, int amount)
        {
            var cardHolder = new CardHolder();

            if (cardHolder.List.Any(s => s.AccNumber == accountNum && s.Balance >= amount)) return true;

            return false;
        }

        // Performs the withdrawal
        public static bool Dispense(int accountNum, int amount)
        {
            //Update Balance
            var cardHolder = new CardHolder();

            //Verifies if amount is exactly divisible by 10
            if (amount % 10 == 0)
            {
                var remainder = amount;
                int thousand = 0, fiveHundred = 0, twoHundred = 0, hundred = 0, fifty = 0, twenty = 0;

                if (remainder >= 1000)
                {
                    thousand = remainder / 1000;
                    remainder %= 1000;
                }
                if (remainder >= 500 && remainder < 1000)
                {
                    fiveHundred = remainder / 500;
                    remainder %= 500;
                }

                if (remainder >= 200 && remainder < 500)
                {
                    twoHundred = remainder / 200;
                    remainder %= 200;
                }

                if (remainder >= 100 && remainder < 200)
                {
                    hundred = remainder / 100;
                    remainder %= 100;
                }

                if (remainder >= 50 && remainder < 100)
                {
                    fifty = remainder / 50;
                    remainder %= 50;
                }

                if (remainder >= 20 && remainder < 50)
                {
                    twenty = remainder / 20;
                    remainder %= 20;
                }               

                var user = cardHolder.List.Find(s => s.AccNumber == accountNum);
                //Displays Old Balance in output window
                Debug.Print("*****************************************");
                Debug.Print("Old Balance: " + user.Balance.ToString());

                user.Balance -= amount;
                //Displays Amount retrieved in output window
                Debug.Print("Amount withdrawn: " + amount);
                //Displays New Balance in output window
                Debug.Print("New Balance: " + user.Balance.ToString());
                Debug.Print("*****************************************");

                //Displays notes dispense in output window
                Debug.Print("*****************************************");
                Debug.Print("You will receive: ");
                Debug.Print(thousand + " Thousand notes  +");
                Debug.Print(fiveHundred + " Five hundred notes +");
                Debug.Print(twoHundred + " Two hundred notes +");
                Debug.Print(hundred + " One hundred notes +");
                Debug.Print(fifty + " Fifty notes +");
                Debug.Print(twenty + " Twenty notes +");
                Debug.Print("*****************************************");

                return true;
            }
            return false;
        }



    }
}