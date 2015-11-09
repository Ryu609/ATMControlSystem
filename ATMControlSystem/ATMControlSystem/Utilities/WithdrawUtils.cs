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

        private static void UpdateBalance(int accountNum, int amount)
        {
            CardHolder cardHolder = new CardHolder();

            var user = cardHolder.List.Find(s => s.AccNumber == accountNum);

            user.Balance = user.Balance - amount;            

        }

        public static bool CheckBalance(int accountNum, int amount)
        {
            CardHolder cardHolder = new CardHolder();

            if (cardHolder.List.Any(s => s.AccNumber == accountNum && s.Balance >= amount)) return true;

            return false;
        }

        public static bool IsCardReported(int cardNum)
        {
            CardDetail cardDetails = new CardDetail();

            return cardDetails.List.Any(s => s.CardNumber == cardNum && s.Reported == true);
        }

        public static void Dispense(int thousand, int fiveHundred, int twoHundred, int hundred, int fifty, int twenty ,int accountNum, int amount)
        {
            UpdateBalance(accountNum, amount);

            Debug.Print("You will receive " + thousand + " Thousand notes + ");
            Debug.Print(fiveHundred + " Five hundred notes +");
            Debug.Print(twoHundred + " Two hundred notes +");
            Debug.Print(hundred + " Five hundred notes +");
            Debug.Print(fifty + " Fifty notes +");
            Debug.Print(twenty + " Twenty notes +");

        }


    }
}