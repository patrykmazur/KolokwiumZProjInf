using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolokwiumZProjInf.Tests
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void GetX_Test()
        {
            var point = new Point(3,5);

            Assert.AreEqual(3,point.GetX());
        }
    }
}
