using ATMControlSystem.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ATMControlSystem.Tests.Controllers
{
    [TestClass]
    public class WithdrawalControllerTest
    {
        [TestMethod]
        public void InsufficientFund()
        {
            // Arrange
            WithdrawalController controller = new WithdrawalController();

            // Act
            ViewResult result = controller.InsufficientFund() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]        
        public void Withdraw()
        {
            // Arrange
            WithdrawalController controller = new WithdrawalController();

            var expectedResult = false;
            var actualResult = controller.Withdraw(00123456789, 1000);


            // Assert
            Assert.AreEqual<bool>(expectedResult, actualResult);
        }

    }

    
}
