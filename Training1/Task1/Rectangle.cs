using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task1
{
    public class Rectangle
    {
        public Rectangle(double leftTopXCorner, double leftTopYCorner, double rightBottomXCorner, double rightBottomYCorner)
        {
            this.LeftTopXCorner = leftTopXCorner;
            this.LeftTopYCorner = leftTopYCorner;
            this.RightBottomXCorner = rightBottomXCorner;
            this.RightBottomYCorner = rightBottomYCorner;
        }

        public double LeftTopXCorner { get; set; }

        public double LeftTopYCorner
        {
            get;

            set;
        }

        public double RightBottomXCorner { get; set; }

        public double RightBottomYCorner { get; set; }

        public double TopSide { get; private set; }

        public double RightSide { get; private set; }

        public double CalcArea()
        {
            this.TopSide = this.CalcLenghtVector(this.LeftTopXCorner, this.RightBottomXCorner, this.LeftTopYCorner, this.LeftTopYCorner);
            this.RightSide = this.CalcLenghtVector(this.RightBottomXCorner, this.RightBottomXCorner, this.LeftTopYCorner, this.RightBottomYCorner);
            return this.TopSide * this.RightSide;
        }

        public double CalcPerimeter()
        {
            this.TopSide = this.CalcLenghtVector(this.LeftTopXCorner, this.RightBottomXCorner, this.LeftTopYCorner, this.LeftTopYCorner);
            this.RightSide = this.CalcLenghtVector(this.RightBottomXCorner, this.RightBottomXCorner, this.LeftTopYCorner, this.RightBottomYCorner);
            return (TopSide + RightSide) * 2;
        }

        private double CalcLenghtVector(double x1, double x2, double y1, double y2)
        {
            return MyMath.GetRoot(MyMath.GetPow((x2 - x1), 2) + MyMath.GetPow((y2 - y1), 2));
        }
    }
}