using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolokwiumZProjInf.Tests
{
    [TestClass]
    public class RectangleTest
    {

        [TestMethod]
        public void DrawRectangleCartesian_Test()
        {
            var startPoint = new Point(3,5);
            var length = 5;
            var rect = new Rectangle();
            var expectedFirstSide = "(8,5)";

            var result = rect.DrawRectangleCartesian(startPoint, length);

            Assert.AreEqual(expectedFirstSide,result.First());
        }

        [TestMethod]
        public void DrawFirstSide_Test()
        {
            var startPoint = new Point(3,5);
            var rect = new Rectangle();
            var length = 5;
            var expected = "(4,5)";

            var result = rect.DrawFirstSide(startPoint, length);

            Assert.IsTrue(result[1]==expected);

        }
        
    }
}