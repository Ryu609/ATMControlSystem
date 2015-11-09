using ATMControlSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Lists
{
    public class CardDetail
    {
        public List<CardModel> List = new List<CardModel>();
        public CardDetail()
        {
            List.Add(new CardModel { CardNumber = 00000123456, Reported = false });
            List.Add(new CardModel { CardNumber = 00123456789, Reported = true });
        }
    }
}