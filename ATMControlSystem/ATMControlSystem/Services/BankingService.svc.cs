﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ATMControlSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BankingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BankingService.svc or BankingService.svc.cs at the Solution Explorer and start debugging.
    public class BankingService : IBankingService
    {
        public bool CardReader(LoginModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispense(int accNumber, int amount)
        {
            throw new NotImplementedException();
        }        

        public void Print(int accNumber, int oldBalance, int newBalance)
        {
            throw new NotImplementedException();
        }
    }
}
