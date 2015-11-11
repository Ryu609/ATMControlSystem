using ATMControlSystem.Lists;
using ATMControlSystem.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMControlSystem.Tests.Utilities
{
    [TestClass]
   public class WithdrawUtilsTest
    {
        [TestMethod]
        public void CheckBalance()
        {
            var expectedResult = true;
            var actualResult = WithdrawUtils.CheckBalance(00000123456, 500);
            
            Assert.AreEqual<bool>(expectedResult, actualResult);

        }

        [TestMethod]
        public void Dispense()
        {
            var expectedResult = true;
            var actualResult = WithdrawUtils.Dispense(00000123456, 500); 

            Assert.AreEqual<bool>(expectedResult, actualResult);
        }
    }
}
