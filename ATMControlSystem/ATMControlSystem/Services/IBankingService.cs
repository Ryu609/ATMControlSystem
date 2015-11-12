using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ATMControlSystem.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBankingService" in both code and config file together.
    [ServiceContract]
    public interface IBankingService
    {
        [OperationContract]
        bool CardReader(LoginModel model);

        [OperationContract]
        void Dispense(int accNumber, int amount);

        [OperationContract]
        void Print(int accNumber, int oldBalance, int newBalance);
        
    }

    [DataContract]
    public class LoginModel
    {
        [DataMember]
        public int AccNumber { get; set; }
        [DataMember]
        public int Password { get; set; }

    }


}
