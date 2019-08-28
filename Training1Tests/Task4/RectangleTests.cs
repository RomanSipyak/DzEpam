using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training1;
using Training1.Task4;

namespace Training1Tests.Task4
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void CalcAreaTestTask4()
        {
            Rectangle.LeftTopXCorner = 1.0;
            Rectangle.LeftTopYCorner = 1.0;
            Rectangle.RightBottomXCorner = 2.0;
            Rectangle.RightBottomYCorner = -3.0;
            Assert.AreEqual(4.0, Math.Round(Rectangle.CalcArea(), 3), 0.001);
            Rectangle.LeftTopXCorner = 0;
            Rectangle.LeftTopYCorner = 0;
            Rectangle.RightBottomXCorner = 10;
            Rectangle.RightBottomYCorner = -10;
            Assert.AreEqual(100, Math.Round(Rectangle.CalcArea(), 3), 0.001);
        }
        [TestMethod]
        public void CalcPerimeterTestTask4()
        {
            Rectangle.LeftTopXCorner = 1.0;
            Rectangle.LeftTopYCorner = 1.0;
            Rectangle.RightBottomXCorner = 2.0;
            Rectangle.RightBottomYCorner = -3.0;
            Assert.AreEqual(10.0, Math.Round(Rectangle.CalcPerimeter(), 3), 0.001);
            Rectangle.LeftTopXCorner = 0;
            Rectangle.LeftTopYCorner = 0;
            Rectangle.RightBottomXCorner = 10;
            Rectangle.RightBottomYCorner = -10;
            Assert.AreEqual(40, Math.Round(Rectangle.CalcPerimeter(), 3), 0.001);
            Rectangle.LeftTopXCorner = 0;
            Rectangle.LeftTopYCorner = 0;
            Rectangle.RightBottomXCorner = 10;
            Rectangle.RightBottomYCorner = 10;
            Assert.AreEqual(40, Math.Round(Rectangle.CalcPerimeter(), 3), 0.001);
        }
    }
}
