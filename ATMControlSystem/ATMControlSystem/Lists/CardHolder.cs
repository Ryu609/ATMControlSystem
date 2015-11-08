using ATMControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Lists
{
    public class CardHolder
    {
        public readonly List<AccountModel> List = new List<AccountModel>();
        public CardHolder()
        {
            List.Add(new AccountModel { AccNumber = "m.joynauth@gmail.com", Password = "test456789" });
            List.Add(new AccountModel { AccNumber = "test@ymail.com", Password = "test1234" });
        }
    }
}