using System;
using System.IO;
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
            Assert.AreEqual(circle.Length, Math.PI * 10);
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
        [TestMethod]
        public void SquCircleTest()
        {
            var circle = new Circle(1, 3, 5);
            Assert.AreEqual(circle.Square, Math.PI * 25);
        }
        [TestMethod]
        public void SquTriangleTest()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 0);
            var p3 = new Point(3, 4);
            var triangle = new Triangle(p1, p2, p3);
            Assert.AreEqual(triangle.Square, 6);
        }
        [TestMethod]
        public void SquQadratTest()
        {
            var p1 = new Point(1, 0);
            var p2 = new Point(3, 0);
            var line = new Line(p1, p2);
            var qadrat = new Qadrat(line);
            Assert.AreEqual(qadrat.Square, 4);
        }
        [TestMethod]
        public void SavePointTest()
        {
            var filePath = Path.Combine(Path.GetTempPath(), "point1.txt");
            var p = new Point(1, 2);
            p.Save(filePath);
            var p2 = new Point(filePath);
            Assert.AreEqual(p2.X, p.X);
            Assert.AreEqual(p2.Y, p.Y);
        }
        [TestMethod]
        public void SavePointTest1()
        {
            var filePath = Path.Combine(Path.GetTempPath(), "point2.txt");
            var p = new Point(123, 2);
            p.Save(filePath);
            var p2 = new Point(filePath);
            Assert.AreEqual(p2.X, p.X);
            Assert.AreEqual(p2.Y, p.Y);
        }
        [TestMethod]
        public void SavePointTest2()
        {
            var filePath = Path.Combine(Path.GetTempPath(), "point3.txt");
            var p = new Point(-123, 200000000);
            p.Save(filePath);
            var p2 = new Point(filePath);
            Assert.AreEqual(p2.X, p.X);
            Assert.AreEqual(p2.Y, p.Y);
        }
        [TestMethod]
        public void SavePointLine()
        {
            var filePath = Path.Combine(Path.GetTempPath(), "point1.txt");
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 4);
            var line1 = new Line(p1, p2);
            line1.Save(filePath);
        }

        [TestMethod]
        public void SaveTriangle()
        {
            var filePath = Path.Combine(Path.GetTempPath(), "triangle1.txt");
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 0);
            var p3 = new Point(3, 4);
            var triangle = new Triangle(p1, p2, p3);
            triangle.Save(filePath); 
        }
    }
}
