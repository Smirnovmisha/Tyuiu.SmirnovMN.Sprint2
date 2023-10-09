using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint2.Task4.V8.Lib;


namespace Tyuiu.SmirnovMN.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 2;
            double res = ds.Calculate(x,y);
            double a = Math.Round(res, 2);
            double wait = 1965921.33;
            Assert.AreEqual(wait, a);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double a = Math.Round(res, 2);
            double wait = 3191.71;
            Assert.AreEqual(wait, a);
        }
    }

}
