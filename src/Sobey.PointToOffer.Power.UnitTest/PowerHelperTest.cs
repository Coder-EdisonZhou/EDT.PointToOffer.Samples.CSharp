using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sobey.PointToOffer.Power.UnitTest
{
    [TestClass]
    public class PowerHelperTest
    {
        // 底数、指数都为正数
        [TestMethod]
        public void PowerTest1()
        {
            Assert.AreEqual(PowerHelper.Power(2, 3), 8);
        }

        // 底数为负数、指数为正数
        [TestMethod]
        public void PowerTest2()
        {
            Assert.AreEqual(PowerHelper.Power(-2, 3), -8);
        }

        // 指数为负数
        [TestMethod]
        public void PowerTest3()
        {
            Assert.AreEqual(PowerHelper.Power(2, -3), 0.125);
        }

        // 指数为0
        [TestMethod]
        public void PowerTest4()
        {
            Assert.AreEqual(PowerHelper.Power(2, 0), 1);
        }

        // 底数、指数都为0
        [TestMethod]
        public void PowerTest5()
        {
            Assert.AreEqual(PowerHelper.Power(0, 0), 1);
        }

        // 底数为0、指数为正数
        [TestMethod]
        public void PowerTest6()
        {
            Assert.AreEqual(PowerHelper.Power(0, 4), 0);
        }

        // 底数为0、指数为负数
        [TestMethod]
        public void PowerTest7()
        {
            Assert.AreEqual(PowerHelper.Power(0, -4), 0);
            Assert.AreEqual(PowerHelper.isInvalidInput, true);
        }
    }
}
