using ATMControlSystem.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Utilities
{
    public static class LoginUtils
    {
        public static bool IsCardReported(int cardNum)
        {
            var cardDetails = new CardDetail();

            return cardDetails.List.Any(s => s.CardNumber == cardNum && s.Reported == true);
        }


    }
}