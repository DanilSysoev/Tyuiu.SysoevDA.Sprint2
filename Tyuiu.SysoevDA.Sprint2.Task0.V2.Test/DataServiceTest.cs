using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SysoevDA.Sprint2.Task0.V2.Lib;

namespace Tyuiu.SysoevDA.Sprint2.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
