using ATMControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Lists
{
    public class CardHolder
    {
        public readonly List<LoginViewModel> List = new List<LoginViewModel>();
        public CardHolder()
        {
            List.Add(new LoginViewModel { AccNumber = 00000123456, Password = "test456789", Balance = 12500 });
            List.Add(new LoginViewModel { AccNumber = 00123456789, Password = "test1234", Balance = 600 });
        }
    }
}