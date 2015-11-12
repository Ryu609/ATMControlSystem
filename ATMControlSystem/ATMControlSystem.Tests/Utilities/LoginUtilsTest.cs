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
   public class LoginUtilsTest
    {
        [TestMethod]
        public void IsCardReported()
        {
            var expectedResult = false;
            var actualResult = LoginUtils.IsCardReported(00000123456);

            Assert.AreEqual<bool>(expectedResult, actualResult);

        }
    }
}
