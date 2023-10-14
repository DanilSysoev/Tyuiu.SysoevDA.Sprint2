using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint2.Task7.V10.Lib;

namespace Tyuiu.SysoevDA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -0.1;
            double y = -1.89;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }

    }
}
