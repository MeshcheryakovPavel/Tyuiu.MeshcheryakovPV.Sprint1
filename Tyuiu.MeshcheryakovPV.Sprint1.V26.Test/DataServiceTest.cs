﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MeshcheryakovPV.Sprint1.Task0.V26.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
