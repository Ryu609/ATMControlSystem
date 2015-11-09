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
        //Update Balance 
        private static void UpdateBalance(int accountNum, int amount)
        {
            CardHolder cardHolder = new CardHolder();

            var user = cardHolder.List.Find(s => s.AccNumber == accountNum);

            user.Balance = user.Balance - amount;            

        }

        //Verifies account balance
        public static bool CheckBalance(int accountNum, int amount)
        {
            CardHolder cardHolder = new CardHolder();

            if (cardHolder.List.Any(s => s.AccNumber == accountNum && s.Balance >= amount)) return true;

            return false;
        }

        // Performs the withdrawal
        public static void Dispense(int accountNum, int amount)
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
            //Update Balance
            UpdateBalance(accountNum, amount);

            //Displays notes dispense in output window
            Debug.Print("You will receive " + thousand + " Thousand notes + ");
            Debug.Print(fiveHundred + " Five hundred notes +");
            Debug.Print(twoHundred + " Two hundred notes +");
            Debug.Print(hundred + " Five hundred notes +");
            Debug.Print(fifty + " Fifty notes +");
            Debug.Print(twenty + " Twenty notes +");

        }


    }
}