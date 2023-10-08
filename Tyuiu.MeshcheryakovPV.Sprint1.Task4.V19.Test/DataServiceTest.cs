using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint1.Task4.V19.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate;
            Assert.AreEqual(wait, res);
        }
    }
}
