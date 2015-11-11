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

            // Act
            ViewResult result = controller.Withdraw(00000123456,500) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }

    
}
