using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint2.Task7.V7.Lib;

namespace Tyuiu.ModenovaAP.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = -0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);

        }

        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = -1;
            bool res2 = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res2, true);
        }
    }
}
