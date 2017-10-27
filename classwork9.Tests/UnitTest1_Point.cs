using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework9_UnitTests;

namespace classwork9.Tests
{
    [TestClass]
    public class UnitTest1_Point
    {
        [TestMethod]
        public void TestDistance()
        {
            Point p1, p2;
            p1 = new Point(0, 0);
            p2 = new Point(1, 0);
            double rez = 1;
            Assert.AreEqual(rez, p1.Distance(p2));
        }

        [TestMethod]
        public void TestConstructor()
        {
            Point p = new Point(2, 4);
            Assert.AreEqual(2, p.X);
            Assert.AreEqual(4, p.Y);
        }

        [TestMethod]
        public void TestToString()
        {
            Point p = new Point(7, 8);
            Assert.AreEqual("(7, 8)", p.ToString());
        }
    }
}
