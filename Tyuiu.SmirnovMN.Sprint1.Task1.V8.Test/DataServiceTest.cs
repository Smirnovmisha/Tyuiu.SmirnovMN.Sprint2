﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.Sprint1.Task1.V8.Lib;


namespace Tyuiu.SmirnovMN.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;
            bool[] res = new bool[6];
            res = ds.GetLogicOperation(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, false, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
