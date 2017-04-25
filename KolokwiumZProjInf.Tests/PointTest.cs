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

        [TestMethod]
        public void GetY_Test()
        {
            var point = new Point(3, 5);
            Assert.AreEqual(5,point.GetY());
        }

        [TestMethod]
        public void CartesianCoordinates_Test()
        {
            var point = new Point(3,5);
            var expected = "(3,5)";

            var result = point.CartesianCoordinates();

            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void PolarCoordinates_Test()
        {
            var point = new Point(3,5);

            var expected = "(5.8309518948453,59.036243467926)";
            var result = point.PolarCoordinates();

            Assert.AreEqual(expected,result);
        }
    }
}
