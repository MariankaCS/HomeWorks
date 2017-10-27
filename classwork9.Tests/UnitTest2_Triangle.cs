using Homework9_UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace classwork9.Tests
{
    [TestClass]
    public class UnitTest2_Triangle
    {
        [TestMethod]
        public void TestCloserToOrigin()
        {
            Triangle a = new Triangle(new Point(6, 3), new Point(2, 7), new Point(5, 4));
            List<Point> list = new List<Point>();
            list.Add(new Point(6, 3));
            list.Add(new Point(2, 7));
            list.Add(new Point(5, 4));
            double result = 6.4;
            Assert.AreEqual(result, Math.Round(a.CloserTooOrigin(), 1));
        }

        [TestMethod]
        public void TestPerimeter()
        {
            Triangle t = new Triangle(new Point(6, 3), new Point(2, 7), new Point(5, 4));
            double result = 11.3;
            Assert.AreEqual(result, Math.Round(t.Perimeter(), 1), 0.1);
        }

        [TestMethod]
        public void TestSquare()
        {
            Triangle t = new Triangle(new Point(1, 3), new Point(2, 7), new Point(6, 2));
            double result = 11;
            Assert.AreEqual(result, Math.Round(t.Square()));
        }
    }
}
