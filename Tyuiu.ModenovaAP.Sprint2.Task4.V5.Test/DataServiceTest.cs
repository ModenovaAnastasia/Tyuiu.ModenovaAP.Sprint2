using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint2.Task4.V5.Lib;

namespace Tyuiu.ModenovaAP.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 438.391;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 24.1;
            Assert.AreEqual(wait, res);
        }
    }
}
