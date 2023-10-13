using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.SysoevDA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("2 Января", ds.FindDateOfNextDay(1,1));
            Assert.AreEqual("2 Февраля", ds.FindDateOfNextDay(2,1));
            Assert.AreEqual("2 Марта", ds.FindDateOfNextDay(3,1));
            Assert.AreEqual("2 Апреля", ds.FindDateOfNextDay(4,1));
            Assert.AreEqual("2 Мая", ds.FindDateOfNextDay(5,1));
            Assert.AreEqual("2 Июня", ds.FindDateOfNextDay(6,1));
            Assert.AreEqual("2 Июля", ds.FindDateOfNextDay(7,1));
            Assert.AreEqual("2 Августа", ds.FindDateOfNextDay(8,1));
            Assert.AreEqual("2 Сентября", ds.FindDateOfNextDay(9,1));
            Assert.AreEqual("2 Октября", ds.FindDateOfNextDay(10,1));
            Assert.AreEqual("2 Ноября", ds.FindDateOfNextDay(11,1));
            Assert.AreEqual("2 Декабря", ds.FindDateOfNextDay(12,1));
            Assert.AreEqual("1 Января", ds.FindDateOfNextDay(12,31));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(13, 32);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 0);
            });
        }

    }
}
