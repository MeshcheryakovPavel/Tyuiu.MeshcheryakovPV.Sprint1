using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MeshcheryakovPV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2, b = 3;
            var res = ds.CalculatePerimetr(a, b);
            //Assert.AreEqual(4, res);
        }
    }
}
