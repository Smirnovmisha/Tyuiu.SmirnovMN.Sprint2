using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint2.Task0.V27.Lib;



namespace Tyuiu.SmirnovMN.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations();
            bool[] wait = new bool[6] { true, false, true, false, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
