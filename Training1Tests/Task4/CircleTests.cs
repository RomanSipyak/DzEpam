using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training1;
using Training1.Task4;

namespace Training1Tests.Task4
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetAreaTestTask4()
        {
            Assert.AreEqual(36.745, Math.Round(Circle.GetArea(3.42), 3), 0.001);
            Assert.AreEqual(3.141, Math.Round(Circle.GetArea(1), 3), 0.001);
            Assert.AreEqual(double.NaN, Circle.GetArea(-2));
        }
        [TestMethod]
        public void GetLengthTestTask4()
        {
            Assert.AreEqual(21.488, Math.Round(Circle.GetLength(3.42), 3), 0.001);
            Assert.AreEqual(6.283, Math.Round(Circle.GetLength(1), 3), 0.001);
            Assert.AreEqual(double.NaN, Circle.GetArea(0));
        }
    }
}
