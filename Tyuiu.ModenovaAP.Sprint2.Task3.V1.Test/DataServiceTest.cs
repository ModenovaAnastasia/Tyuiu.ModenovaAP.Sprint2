using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint2.Task3.V1.Lib;

namespace Tyuiu.ModenovaAP.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -8.741;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -17.027;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -17.027;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -9;
            double wait = -98.999;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
