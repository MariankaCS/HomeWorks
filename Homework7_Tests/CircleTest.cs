using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework7;

namespace Homework7.Tests
{
    [TestClass]
    public class CircleTest
    {
        //public override double Perimeter()
        //{
        //    double perimeter = 2 * Math.PI * Radius;
        //    return perimeter;
        //}

        [TestMethod]
        public void TestCircleConstructor()
        {
            Circle c = new Circle("Volf", 2);
            Assert.AreEqual("Volf", c.Name);
            Assert.AreEqual(2, c.Radius);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            Circle c = new Circle("Volf", 2);
            double result = 12.56;
            Assert.AreEqual(result, c.Area(), 0.1);
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            Circle c = new Circle("Bunny", 3);
            double result = 18.84;
            Assert.AreEqual(result, c.Perimeter(), 0.1);
        }
    }
}
