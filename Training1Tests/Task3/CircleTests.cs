using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training1;
using Training1.Task3;

namespace Training1Tests.Task3
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetAreaTestTask3()
        {
            Circle circle = new Circle();
            Assert.AreEqual(36.745, Math.Round(circle.GetArea(3.42), 3), 0.001);
            Assert.AreEqual(3.141, Math.Round(circle.GetArea(1), 3), 0.001);
            Assert.AreEqual(double.NaN, circle.GetArea(-2));
        }
        [TestMethod]
        public void GetLengthTestTask3()
        {
            Circle circle = new Circle();
            Assert.AreEqual(21.488, Math.Round(circle.GetLength(3.42), 3), 0.001);
            Assert.AreEqual(6.283, Math.Round(circle.GetLength(1), 3), 0.001);
            Assert.AreEqual(double.NaN, circle.GetArea(0));
        }
    }
}
