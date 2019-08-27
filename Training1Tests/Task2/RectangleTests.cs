using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training1;
using Training1.Task2;

namespace Training1Tests.Task2
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void CalcAreaTestTask2()
        {
            Rectangle rec = new Rectangle(1.0, 1.0, 2.0, -3.0);
            Assert.AreEqual(4.0, Math.Round(rec.CalcArea, 3), 0.001);
            rec.LeftTopXCorner = 0;
            rec.LeftTopYCorner = 0;
            rec.RightBottomXCorner = 10;
            rec.RightBottomYCorner = -10;
            Assert.AreEqual(100, Math.Round(rec.CalcArea, 3), 0.001);
        }
        [TestMethod]
        public void CalcPerimeterTestTask2()
        {
            Rectangle rec = new Rectangle(1.0, 1.0, 2.0, -3.0);
            Assert.AreEqual(10.0, Math.Round(rec.CalcPerimeter, 3), 0.001);
            rec.LeftTopXCorner = 0;
            rec.LeftTopYCorner = 0;
            rec.RightBottomXCorner = 10;
            rec.RightBottomYCorner = -10;
            Assert.AreEqual(40, Math.Round(rec.CalcPerimeter, 3), 0.001);
            rec.LeftTopXCorner = 0;
            rec.LeftTopYCorner = 0;
            rec.RightBottomXCorner = 10;
            rec.RightBottomYCorner = 10;
            Assert.AreEqual(40, Math.Round(rec.CalcPerimeter, 3), 0.001);
        }
    }
}
