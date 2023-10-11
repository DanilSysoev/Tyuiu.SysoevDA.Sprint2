using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint2.Task3.V24.Lib;

namespace Tyuiu.SysoevDA.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;

            double res = ds.Calculate(x);

            Assert.AreEqual(10.988, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;

            double res = ds.Calculate(x);

            Assert.AreEqual(Math.Cos(x) + (12 / Math.Pow(x, 2)), res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -20;

            double res = ds.Calculate(x);

            Assert.AreEqual(0.951, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -50;

            double res = ds.Calculate(x);

            Assert.AreEqual(2000.02, res);
        }
    }
}
