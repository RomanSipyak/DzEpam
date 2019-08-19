using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task4
{
    public static class Rectangle
    {
        public static double LeftTopXCorner { get; set; }

        public static double LeftTopYCorner { get; set; }

        public static double RightBottomXCorner { get; set; }

        public static double RightBottomYCorner { get; set; }

        public static double TopSide { get; private set; }

        public static double RightSide { get; private set; }

        public static double CalcArea()
        {
            double TopSide = CalcLenghtVector(LeftTopXCorner, RightBottomXCorner, LeftTopYCorner, LeftTopYCorner);
            double RightSide = CalcLenghtVector(RightBottomXCorner, RightBottomXCorner, LeftTopYCorner, RightBottomYCorner);
            return TopSide * RightSide;
        }

        public static double CalcPerimeter()
        {
            double TopSide = CalcLenghtVector(LeftTopXCorner, RightBottomXCorner, LeftTopYCorner, LeftTopYCorner);
            double RightSide = CalcLenghtVector(RightBottomXCorner, RightBottomXCorner, LeftTopYCorner, RightBottomYCorner);
            return (TopSide + RightSide) * 2;
        }

        private static double CalcLenghtVector(double x1, double x2, double y1, double y2)
        {
            return MyMath.GetRoot(MyMath.GetPow((x2 - x1), 2) + MyMath.GetPow((y2 - y1), 2));
        }
    }
}
