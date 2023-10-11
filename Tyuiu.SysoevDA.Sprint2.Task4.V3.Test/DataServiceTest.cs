using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.SysoevDA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 19;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(21, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = -1;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(4, res);
        }
    }
}
