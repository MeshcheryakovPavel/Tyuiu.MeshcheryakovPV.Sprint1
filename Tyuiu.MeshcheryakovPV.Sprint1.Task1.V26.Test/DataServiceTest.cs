using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint1.Task1.V26.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.Task1.V26.Test
{
    //5*x/ (2+y)
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.25 , res);
               
        }
    }
}
