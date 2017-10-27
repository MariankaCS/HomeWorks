using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework7;

namespace Homework7_Tests
{


    //public override double Perimeter()
    //{
    //    double perimeter = 4 * Side;
    //    return perimeter;
    //}
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square s = new Square("Fox", 2.5);
            Assert.AreEqual("Fox", s.Name);
            Assert.AreEqual(2.5, s.Side);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square s = new Square("Billy", 3);
            double result = 9;
            Assert.AreEqual(result, s.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square s = new Square("Billy", 4);
            double result = 16;
            Assert.AreEqual(result, s.Area());
        }

    }
}
