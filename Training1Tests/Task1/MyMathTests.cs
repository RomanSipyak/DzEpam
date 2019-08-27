using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training1;
namespace Training1Tests.Task1
{
    [TestClass]
    public class MyMathTests
    {
        [TestMethod]
        public void GetRootTest()
        {
            Assert.AreEqual(7,Math.Round(MyMath.GetRoot(49),3), 0.001);
            Assert.AreEqual(3.741,Math.Round(MyMath.GetRoot(14),3), 0.001);
            Assert.AreEqual(Double.NaN, MyMath.GetRoot(-15));
        }
        [TestMethod]
        public void GetPowTest()
        {
            Assert.AreEqual(27, Math.Round(MyMath.GetPow(3,3), 3), 0.001);
            Assert.AreEqual(1, Math.Round(MyMath.GetPow(2,0), 3), 0.001);
            Assert.AreEqual(4, Math.Round(MyMath.GetPow(-2, 2), 3), 0.001);
            Assert.AreEqual(6.003, Math.Round(MyMath.GetPow(-2.45, 2), 3), 0.001);
        }
    }
}

