using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LenLineTest()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 4);
            var line = new Line(p1, p2);
            Assert.AreEqual(line.Length, 5);
        }
        [TestMethod]
        public void LenCircleTest()
        {
            var circle = new Circle(1, 3, 5);
            Assert.AreEqual(circle.Length, Math.PI*10);
        }
        [TestMethod]
        public void LenTriangleTest()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 0);
            var p3 = new Point(3, 4);
            var triangle = new Triangle(p1, p2, p3);
            Assert.AreEqual(triangle.Length, 12);
        }
        [TestMethod]
        public void LenQadratTest()
        {
            var p1 = new Point(1, 0);
            var p2 = new Point(3, 0);
            var line = new Line(p1, p2);
            var qadrat = new Qadrat(line);
            Assert.AreEqual(qadrat.Length, 8);
        }
    }
}
